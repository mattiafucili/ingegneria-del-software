using System;

namespace Project.model {


	public static partial class BonusAlgorithmStrategy {

		private class SquareAlgorithm : BonusAlgorithm {

			public string Name {
				get {
					return ("^2");
				}
			}

			public int CalculateBonus(int score) {
				#region Preconditions
				if (score < 0)
					throw (new ArgumentException("Score less than zero!"));
				#endregion

				return (score * score);
			}
		}

	}


}
