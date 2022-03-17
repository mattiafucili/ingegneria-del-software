using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {


	public delegate void UserEvent(object obj, PlayerArgs args);

	public partial class Manager {
		private static Manager manager = null;
		private readonly Users users;
		
		public event EventHandler AvailableUsersChanged;

		private Manager() {
			users = new Users();
		}

		public static Manager GetInstance() {
			if ( manager == null )
				manager = new Manager();
			return (manager);
		}

		public void AttachUser(string username, EventHandler User_GameStarted) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (!users.Exists(username))
				throw (new ArgumentException("Invalid username!"));
			if (User_GameStarted == null)
				throw (new ArgumentException("Event handler null!"));
			#endregion

			users.GetByUsername(username).GameStarted += User_GameStarted;
		}

		public void DetachUser(string username, EventHandler User_GameStarted) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (!users.Exists(username))
				throw (new ArgumentException("Invalid username!"));
			if (User_GameStarted == null)
				throw (new ArgumentException("Event handler null!"));
			#endregion

			users.GetByUsername(username).GameStarted -= User_GameStarted;
		}

		public IEnumerable<Player> FindAvailablePlayers() {
			return (users.AvailableUsers);
		}

		public bool AddUser(string username, string password) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (password == null)
				throw (new ArgumentException("Password null!"));
			#endregion
			
			return ( users.AddUser(username, password) );
		}

		public bool Login(string username, string password) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (password == null)
				throw (new ArgumentException("Password null!"));
			#endregion

			bool result = users.Login(username, password);
			if ( result )
				OnAvailableUsersChanged();
			return (result);
		}

		public bool Logout(string username, string password) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (password == null)
				throw (new ArgumentException("Password null!"));
			#endregion

			bool result = users.Logout(username, password);
			if (result)
				OnAvailableUsersChanged();
			return (result);
		}

		public void NewGameUserVsUser(List<string> names) {
			#region Preconditions
			if (names == null)
				throw (new ArgumentException("Names list is null!"));
			foreach (string name in names)
				if (name == null)
					throw (new ArgumentException("A name in names list is null!"));
				else if (!users.Exists(name))
					throw (new ArgumentException("A user does not exist!"));
			#endregion

			List<Player> players = new List<Player>();
			foreach (string name in names) {
				Player player = users.GetByUsername(name);
				players.Add(player);
			}

			CreateGame(players);
		}

		public void NewGameUserVsComputer(string username, string difficulty) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (difficulty == null)
				throw (new ArgumentException("Difficulty null!"));
			if (!DifficultyFlyweight.Difficulties.Contains(difficulty))
				throw (new ArgumentException("Invalid difficulty name!"));
			#endregion

			Player user = users.GetByUsername(username);
			Player pc = Users.NewComputer();
			List<Player> players = new List<Player>();
			players.Add(user);
			players.Add(pc);

			CreateGame(players, difficulty);
		}

		private void CreateGame(List<Player> players, string difficulty = "None") {
			Vocabulary vocabulary = Vocabulary.GetInstance();
			Word randomWord = vocabulary.RandomWord();

			Game game = new PrivateGame(players, difficulty, randomWord);
			game.PlayersStateChanged += Game_EndGameForUser;
			foreach (Player player in players)
				player.CurrentGame = game;

			OnAvailableUsersChanged();
		}

		public Game GameByUsername(string username) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (!users.Exists(username))
				throw (new ArgumentException("Invalid username!"));
			#endregion

			User user = users.GetByUsername(username);
			return (user.CurrentGame);
		}

		public IEnumerable<Statistics> StatisticsByUsername(string username) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (!users.Exists(username))
				throw (new ArgumentException("Invalid username!"));
			#endregion

			User user = users.GetByUsername(username);
			return (user.AllStatistics);
		}

		public IEnumerable<User> GetRanking() {
			return (users.SortedList);
		}

		protected virtual void OnAvailableUsersChanged() {
			if ( AvailableUsersChanged != null )
				AvailableUsersChanged(this, EventArgs.Empty);
		}

		private void Game_EndGameForUser(object sender, PlayerArgs args) {
			List<Player> players = args.Players;
			foreach (Player player in players) {
				if (player is User)
					UpdateStatistics((User)player, GameByUsername(player.Username));
				player.CurrentGame = null;
			}
			OnAvailableUsersChanged();
		}

		private void UpdateStatistics(User user, Game game) {
			Statistics statistics = user.GetStatistics(game.Difficulty);
			statistics.Add(game.StartTime, game.GetState(user.Username), game.GetScore(user.Username));
		}

	}


}

