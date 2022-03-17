using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {


	public abstract partial class User {

		private partial class PrivateStatistics : Statistics {
			private readonly string difficulty;
			private readonly List<Element> history;

			public PrivateStatistics(string difficulty) {
				this.difficulty = difficulty;
				history = new List<Element>();
			}

			public string Difficulty {
				get {
					return (difficulty);
				}
			}

			public int Count {
				get {
					return (history.Count);
				}
			}

			public int Win {
				get {
					return (history.Count(x => x.GameState == GameState.WIN));
				}
			}

			public int Defeat {
				get {
					return (history.Count(x => x.GameState == GameState.DEFEAT));
				}
			}

			public int Draw {
				get {
					return (history.Count(x => x.GameState == GameState.DRAW));
				}
			}

			public int TotalScore {
				get {
					return (history.Sum(element => element.Score));
				}
			}

			public int MaximumScore {
				get {
					if (history.Count == 0)
						return (0);
					return (history.Max(element => element.Score));
				}
			}

			public double AverageScore {
				get {
					if (history.Count == 0)
						return (0);
					return (history.Average(element => element.Score));
				}
			}

			public void Add(DateTime date, GameState gameState, int score) {
				#region Preconditions
				if (score < 0)
					throw (new ArgumentException("Score less than zero!"));
				if (gameState == GameState.DEFEAT && score > 0)
					throw (new ArgumentException("Invalid history element!"));
				#endregion

				history.Add(new Element(date, gameState, score));
			}

		}

	}


}
