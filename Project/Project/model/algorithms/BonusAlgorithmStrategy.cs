using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Project.model {


	public static partial class BonusAlgorithmStrategy {
		private static readonly Dictionary<string, BonusAlgorithm> algorithms;

		static BonusAlgorithmStrategy() {
			algorithms = new Dictionary<string, BonusAlgorithm>();

			string interfaceName = typeof(BonusAlgorithm).Name;
			IEnumerable<BonusAlgorithm> algorithmsList = from type in Assembly.GetExecutingAssembly().GetTypes()
														 where (type.GetInterface(interfaceName, true) != null)
														 where (type.IsClass) && (!type.IsAbstract)
														 where (type.GetConstructor(Type.EmptyTypes) != null)
														 select ((BonusAlgorithm) Activator.CreateInstance(type));

			foreach (BonusAlgorithm algorithm in algorithmsList)
				algorithms.Add(algorithm.Name, algorithm);
		}

		public static IEnumerable<string> All {
			get {
				return (from algorithm in algorithms
						select algorithm.Key);
			}
		}

		public static BonusAlgorithm DefaultAlgorithm {
			get {
				return (algorithms["x2"]);
			}
		}

		public static BonusAlgorithm GetAlgorithm(string name) {
			#region Prectionditions
			if (name == null)
				throw (new ArgumentException("Bonus algorithm name null!"));
			if (!algorithms.ContainsKey(name))
				throw (new ArgumentException("Invalid bonus algorithm name!"));
			#endregion

			return (algorithms[name]);
		}

	}


}
