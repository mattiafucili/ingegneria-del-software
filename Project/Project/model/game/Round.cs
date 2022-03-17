
namespace Project.model {


	public partial class Manager {

		private partial class PrivateGame : Game {

			private class Round {
				private readonly Player player;
				private readonly Word word;
				private int score;

				public Round(Player player, Word word, int score) {
					this.player = player;
					this.word = word;
					this.score = score;
				}

				public Player Player {
					get {
						return (player);
					}
				}

				public Word Word {
					get {
						return (word);
					}
				}

				public int Score {
					get {
						return (score);
					}
				}

			}

		}

	}


}
