using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {

	public partial class Manager {

		private partial class PrivateGame : Game {
			private readonly Dictionary<Player, GameState> playersTable;
			private readonly Dictionary<Player, Help> helpsTable;

			private readonly Random r;
			private char charBonus;

			private readonly DateTime startTime;
			private readonly string difficulty; // None, Easy, Medium, Hard, Impossible
			private readonly List<Round> roundsList;

			public event EventHandler GameChanged;
			public event UserEvent PlayersStateChanged;

			public PrivateGame(List<Player> players, string difficulty, Word firstWord) {
				#region Preconditions
				if (players == null)
					throw (new ArgumentException("Players list null!"));
				if (players.Count < 2)
					throw (new ArgumentException("Few players!"));
				foreach (Player player in players)
					if (player == null)
						throw (new ArgumentException("Player null!"));
				if (!IsValid(players))
					throw (new ArgumentException("Invalid game!"));
				if (!DifficultyFlyweight.Difficulties.Contains(difficulty))
					throw (new ArgumentException("Invalid difficulty name!"));
				if (firstWord == null)
					throw (new ArgumentException("First word null!"));
				Vocabulary vocabulary = Vocabulary.GetInstance();
				if (!vocabulary.Exists(firstWord.Name))
					throw (new ArgumentException("First word does not exists!"));
				if (IsThereComputer(players) && difficulty.Equals("None"))
					throw (new ArgumentException("Game with computer, difficulty not set!"));
				if (!IsThereComputer(players) && !difficulty.Equals("None"))
					throw (new ArgumentException("Game between users - difficulty is set!"));
				#endregion

				playersTable = new Dictionary<Player, GameState>();
				helpsTable = new Dictionary<Player, Help>();
				foreach (Player player in players) {
					playersTable.Add(player, GameState.NOT_SET);
					helpsTable.Add(player, HelpFactory.BuildHelp(player.Username, "best"));
				}

				r = new Random();
				charBonus = Bonus();

				startTime = DateTime.Now;
				this.difficulty = difficulty;
				roundsList = new List<Round>();
				roundsList.Add(new Round(null, firstWord, 0));
			}

			private bool IsThereComputer(List<Player> players) {
				foreach (Player player in players)
					if ( player is Computer )
						return (true);
				return (false);
			}

			private bool IsValid(List<Player> players) {
				if ( IsThereComputer(players) )
					return (players.Count == 2);
				return (!RepeatedElements(players));
			}

			private bool RepeatedElements(List<Player> players) {
				List<Player> listCopy = new List<Player>();
				listCopy.AddRange(players);

				while (listCopy.Count > 0) {
					Player first = listCopy.ElementAt(0);
					listCopy.RemoveAt(0);
					if ( listCopy.Contains(first) )
						return (true);
				}
				return (false);
			}

			public IEnumerable<Player> Players {
				get {
					return (from playerEntry in playersTable
							select playerEntry.Key);
				}
			}

			public GameState GetState(string username) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Player name null!"));
				if (!IsPlayer(username))
					throw (new ArgumentException("Invalid player name!"));
				#endregion

				return ( playersTable[PlayerByName(username)] );
			}

			public int GetScore(string username) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Player name null!"));
				if (!IsPlayer(username))
					throw (new ArgumentException("Invalid player name!"));
				#endregion

				if ( playersTable[PlayerByName(username)] == GameState.DEFEAT )
					return (0);

				Player player = PlayerByName(username);
				IEnumerable<int> scores = from round in roundsList
										  where player.Equals(round.Player)
										  select round.Score;
				return (scores.Sum());
			}

			public string CurrentPlayer {
				get {
					List<Player> remainingPlayers = RemainingPlayers.ToList();
					if ( remainingPlayers.Count() == 0 )
						return (null);

					Player lastPlayer = roundsList.Last().Player;
					if (lastPlayer == null || lastPlayer.Equals(remainingPlayers.Last()))
						return (remainingPlayers.First().Username);

					int index = remainingPlayers.IndexOf(lastPlayer) + 1;
					return ((remainingPlayers.ElementAt(index)).Username);
				}
			}

			private IEnumerable<Player> RemainingPlayers {
				get {
					return (from playerEntry in playersTable
							where playerEntry.Value == GameState.NOT_SET
							select playerEntry.Key);
				}
			}

			private Player PlayerByName(string username) {
				return (Players.FirstOrDefault( x => x.Username.Equals(username )));
			}

			public bool IsEnded {
				get {
					return (RemainingPlayers.Count() == 0);
				}	
			}

			public DateTime StartTime {
				get {
					return (startTime);
				}
			}

			public string Difficulty {
				get {
					return (difficulty);
				}
			}

			public IEnumerable<Word> WordsList {
				get {
					return (from round in roundsList
							select round.Word);
				}
			}

			public Word LastWord {
				get {
					return (roundsList.Last().Word);
				}
			}

			public char CharBonus {
				get {
					return (charBonus);
				}
			}

			public bool Play(string username, string word) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Player name null!"));
				if (word == null)
					throw (new ArgumentException("Word null!"));
				if (RemainingPlayers.Count() == 0)
					throw (new ArgumentException("Game it's over!"));
				if (!IsPlayer(username))
					throw (new ArgumentException("It isn't you're game!"));
				if (!username.Equals(CurrentPlayer))
					throw (new ArgumentException("It isn't you're moment, please wait..."));
				#endregion

				Vocabulary vocabulary = Vocabulary.GetInstance();
				if ( !vocabulary.Exists(word) || !(word.StartsWith(LastWord.LastSyllable)) ) {
					return (Defeat(username));
				}

				Word newWord = vocabulary.WordByName(word);
				if ( WordsList.Contains(newWord)) {
					return (Defeat(username));
				}

				int wordScore = newWord.Evaluate(CharBonus);
				Player player = PlayerByName(username);
				Round newRound = new Round(player, newWord, wordScore);
				roundsList.Add(newRound);

				if ( !CanContinue() )
					return (Draw());

				return (Continue());
			}

			private bool IsPlayer(string username) {
				Player result = Players.FirstOrDefault(x => x.Username.Equals(username));
				return (result != null);
			}

			private bool Defeat(string username) {
				List<Player> modifiedPlayers = new List<Player>();

				Player player = PlayerByName(username);
				playersTable[player] = GameState.DEFEAT;
				modifiedPlayers.Add(player);

				IEnumerable<Player> remainingPlayers = RemainingPlayers;
				int remainigPlayersCount = remainingPlayers.Count();

				if (remainigPlayersCount == 1) {
					Player winner = remainingPlayers.First();
					playersTable[winner] = GameState.WIN;
					modifiedPlayers.Add(winner);
				}

				OnChanged();
				OnPlayersStateChanged(modifiedPlayers);

				if ( IsEnded )
					return (false);
				return (Continue());
			}

			private bool Draw() {
				List<Player> modifiedPlayers = new List<Player>();
				while (RemainingPlayers.Count() > 0) {
					Player player = RemainingPlayers.First();
					playersTable[player] = GameState.DRAW;
					modifiedPlayers.Add(player);
				}

				OnChanged();
				OnPlayersStateChanged(modifiedPlayers);
				return (false);
			}

			private bool Continue() {
				charBonus = Bonus();
				OnChanged();
				return (true);
			}

			private bool CanContinue() {
				Vocabulary vocabulary = Vocabulary.GetInstance();
				foreach (Word word in vocabulary.All)
					if ( word.Name.StartsWith(LastWord.LastSyllable) && !WordsList.Contains(word) )
						return (true);
				return (false);
			}

			private char Bonus() {
				return ((char) r.Next(97, 123));
			}

			public bool HasHelp(string username) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Player name null!"));
				if (!IsPlayer(username))
					throw (new ArgumentException("Invalid player name!"));
				#endregion

				Player player = PlayerByName(username);
				Help help = helpsTable[player];
				return (help.Available);
			}

			public string GetHelp(string username) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Player name null!"));
				if (!IsPlayer(username))
					throw (new ArgumentException("Invalid player name!"));
				if (!HasHelp(username))
					throw (new ArgumentException("Unavailable help!"));
				#endregion

				Player player = PlayerByName(username);
				Help help = helpsTable[player];
				Word word = help.GetHelp(WordsList, WordsList.Last(), CharBonus);

				return (word.Name);
			}

			public void GiveUp(string username) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Player name null!"));
				if (!IsPlayer(username))
					throw (new ArgumentException("Invalid player name!"));
				#endregion

				List<Player> modifiedPlayers = new List<Player>();

				Player player = PlayerByName(username);
				playersTable[player] = GameState.DEFEAT;
				modifiedPlayers.Add(player);

				IEnumerable<Player> remainingPlayers = RemainingPlayers;
				int remainigPlayersCount = remainingPlayers.Count();

				if (remainigPlayersCount == 1) {
					Player winner = remainingPlayers.First();
					playersTable[winner] = GameState.WIN;
					modifiedPlayers.Add(winner);
				}

				OnChanged();
				OnPlayersStateChanged(modifiedPlayers);
			}

			private void OnChanged() {
				if ( GameChanged != null )
					GameChanged(this, EventArgs.Empty);
			}

			private void OnPlayersStateChanged(List<Player> players) {
				if ( PlayersStateChanged != null ) {
					PlayerArgs playerArgs = new PlayerArgs();
					playerArgs.Players = players;
					PlayersStateChanged(this, playerArgs);
				}
			}

		}

	}


}
