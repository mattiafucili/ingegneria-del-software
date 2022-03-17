using System;

namespace Project.model {


	public static partial class BonusAlgorithmStrategy {

		private class DoublerAlgorithm : BonusAlgorithm {

			public string Name {
				get {
					return ("x2");
				}
			}
			
			public int CalculateBonus(int score) {
				#region Preconditions
				if (score < 0)
					throw (new ArgumentException("Score less than zero!"));
				#endregion

				return (score * 2);
			}
		}

	}


}
