using System;
using System.Threading;

namespace Project.model {


	public abstract class Computer : Player {
		private readonly Random random;

		public Computer(string username) : base(username) {
			random = new Random();
			GameStarted += Computer_GameStarted;
		}

		private void Computer_GameStarted(object sender, EventArgs e) {
			GameStarted -= Computer_GameStarted;
			CurrentGame.GameChanged += CurrentGame_Changed;
		}

		private void CurrentGame_Changed(object sender, EventArgs e) {
			if ( CurrentGame.GetState(Username) != GameState.NOT_SET ) {
				CurrentGame.GameChanged -= CurrentGame_Changed;
			} else {
				if (CurrentGame.CurrentPlayer.Equals(Username)) {
					Play();
				}
			}
		}

		private void Play() {
			Difficulty difficulty = DifficultyFlyweight.GetDifficulty(CurrentGame.Difficulty);
			bool answer = difficulty.Answer();
			if (!answer)
				CurrentGame.Play(Username, "notexists");
			else {
				Thread t = new Thread(GenerateWord);
				t.Start();
			}
		}

		private void GenerateWord() {
			Thread.Sleep(1000);
			Help help = HelpFactory.BuildHelp(Username, "random");
			Word word = help.GetHelp(CurrentGame.WordsList, CurrentGame.LastWord, CurrentGame.CharBonus);
			CurrentGame.Play(Username, word.Name);
		}

	}

	public partial class Manager {

		private partial class Users {

			private class PrivateComputer : Computer {

				public PrivateComputer() : base("Albert Einstein") { }

			}

		}

	}


}