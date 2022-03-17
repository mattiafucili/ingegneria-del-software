using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Project.model {


	public static partial class DifficultyFlyweight {
		private static readonly Dictionary<string, Difficulty> difficultyTable;

		static DifficultyFlyweight() {
			difficultyTable = new Dictionary<string, Difficulty>();

			string interfaceName = typeof(Difficulty).Name;

			IEnumerable<Difficulty> difficulties = from type in Assembly.GetExecutingAssembly().GetTypes()
												   where (type.GetInterface(interfaceName, true) != null)
												   where (type.IsClass) && (!type.IsAbstract)
												   where (type.GetConstructor(Type.EmptyTypes) != null)
												   select ((Difficulty) Activator.CreateInstance(type));

			foreach (Difficulty difficulty in difficulties)
				difficultyTable.Add(difficulty.Name, difficulty);

			// Easy				Difficulty(85);
			// Medium			Difficulty(90);
			// Hard				Difficulty(95);
			// Impossible		Difficulty(99);
			// None				Difficulty(100) --> Vs. other users
		}

		public static IEnumerable<string> Difficulties {
			get {
				return (from difficulty in difficultyTable
						select difficulty.Key);
			}
		}

		public static Difficulty GetDifficulty(string difficulty) {
			#region Preconditions
			if (difficulty == null)
				throw (new ArgumentException("Difficulty name null!"));
			if (!Difficulties.Contains(difficulty))
				throw (new ArgumentException("Invalid difficulty name!"));
			#endregion

			return (difficultyTable[difficulty]);
		}

	}


}
