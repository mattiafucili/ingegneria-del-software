using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Project.model {


	public static partial class HelpStrategy {
		private static readonly Dictionary<string, HelpAlgorithm> algorithms;

		static HelpStrategy() {
			algorithms = new Dictionary<string, HelpAlgorithm>();

			string interfaceName = typeof(HelpAlgorithm).Name;
			IEnumerable<HelpAlgorithm> algorithmsList = from type in Assembly.GetExecutingAssembly().GetTypes()
														where (type.GetInterface(interfaceName, true) != null)
														where (type.IsClass) && (!type.IsAbstract)
														where (type.GetConstructor(Type.EmptyTypes) != null)
														select ((HelpAlgorithm)Activator.CreateInstance(type));

			foreach (HelpAlgorithm algorithm in algorithmsList)
				algorithms.Add(algorithm.Name, algorithm);
		}

		public static IEnumerable<string> All {
			get {
				return (from algorithm in algorithms
						select algorithm.Key);
			}
		}

		public static HelpAlgorithm GetAlgorithm(string name) {
			#region Prectionditions
			if (name == null)
				throw (new ArgumentException("Help algorithm name null!"));
			if (!algorithms.ContainsKey(name))
				throw (new ArgumentException("Invalid help algorithm name!"));
			#endregion

			return (algorithms[name]);
		}

	}


}
