using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {


	public abstract partial class User : Player {
		private readonly string password;
		private readonly Dictionary<string, Statistics> allStatistics;

		public User(string username, string password) : base(username) {
			#region Preconditions
			if (password == null)
				throw (new ArgumentException("Password null!"));
			#endregion

			this.password = password;
			allStatistics = new Dictionary<string, Statistics>();
			foreach (string difficulty in DifficultyFlyweight.Difficulties)
				allStatistics.Add(difficulty, new PrivateStatistics(difficulty));

			//None				NoneStatistics();
			//Easy				EasyStatistics();
			//Medium			MediumStatistics();
			//Hard				HardStatistics;
			//Impossible		ImpossibleStatistics();
		}

		public string Password {
			get {
				return (password);
			}
		}

		public IEnumerable<Statistics> AllStatistics {
			get {
				return (allStatistics.Values);
			}
		}

		public Statistics GetStatistics(string difficulty) {
			#region Preconditions
			if (difficulty == null)
				throw (new ArgumentException("Difficulty name null!"));
			if (!DifficultyFlyweight.Difficulties.Contains(difficulty))
				throw (new ArgumentException("Invalid difficulty!"));
			#endregion

			return (allStatistics[difficulty]);
		}

	}

	public partial class Manager {

		private partial class Users {

			private class PrivateUser : User {

				public PrivateUser(string username, string password) : base(username, password) { }

			}

		}

	}


}
