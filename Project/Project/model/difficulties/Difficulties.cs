using System;

namespace Project.model {


	public static partial class DifficultyFlyweight {

		private abstract class AbstractDifficulty : Difficulty {
			private readonly Random r;

			public AbstractDifficulty() {
				r = new Random();
			}

			public abstract string Name { get; }

			public abstract string DisplayName { get; }

			public abstract int Probability { get; }

			public bool Answer() {
				int i = r.Next(1, 101);
				return (i <= Probability);
			}
		}

		private class Easy : AbstractDifficulty {

			public override string Name {
				get {
					return ("Easy");
				}
			}

			public override string DisplayName {
				get {
					return ("Facile");
				}
			}

			public override int Probability {
				get {
					return (85);
				}
			}
		}

		private class Medium : AbstractDifficulty {

			public override string Name {
				get {
					return ("Medium");
				}
			}

			public override string DisplayName {
				get {
					return ("Medio");
				}
			}

			public override int Probability {
				get {
					return (90);
				}
			}
		}

		private class Hard : AbstractDifficulty {

			public override string Name {
				get {
					return ("Hard");
				}
			}

			public override string DisplayName {
				get {
					return ("Difficile");
				}
			}

			public override int Probability {
				get {
					return (95);
				}
			}
		}

		private class Impossible : AbstractDifficulty {

			public override string Name {
				get {
					return ("Impossible");
				}
			}

			public override string DisplayName {
				get {
					return ("Impossibile");
				}
			}

			public override int Probability {
				get {
					return (99);
				}
			}
		}

		private class None : AbstractDifficulty {

			public override string Name {
				get {
					return ("None");
				}
			}

			public override string DisplayName {
				get {
					return ("Vs. altri utenti");
				}
			}

			public override int Probability {
				get {
					return (100);
				}
			}
		}

	}


}
