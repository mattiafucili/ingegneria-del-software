using System;

namespace Project.model {


	public abstract partial class User {

		private partial class PrivateStatistics : Statistics {

			private class Element {
				private readonly DateTime date;
				private readonly GameState gameState;
				private readonly int score;

				public Element(DateTime date, GameState gameState, int score) {
					this.date = date;
					this.gameState = gameState;
					this.score = score;
				}

				public DateTime Date {
					get {
						return (date);
					}
				}

				public GameState GameState {
					get {
						return (gameState);
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
