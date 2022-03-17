using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {


	public partial class Manager {

		private partial class Users {
			private readonly Dictionary<User, bool> usersTable;
			private int online;
			private int offline;

			public Users() {
				usersTable = new Dictionary<User, bool>();

				online = 0;
				offline = 0;
			}

			public IEnumerable<User> All {
				get {
					return (from entry in usersTable
							select entry.Key);
				}
			}

			public IEnumerable<User> AvailableUsers {
				get {
					return (from entry in usersTable
							where entry.Value == true
							where entry.Key.CurrentGame == null
							select entry.Key);
				}
			}

			public IEnumerable<User> SortedList {
				get {
					return (from user in All
							orderby (user.GetStatistics("None").TotalScore) descending
							select user);
				}
			}

			public int Online {
				get {
					return (online);
				}
			}

			public int Offline {
				get {
					return (offline);
				}
			}

			public int Count {
				get {
					return (usersTable.Count);
				}
			}

			public bool AddUser(string username, string password) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Username null!"));
				if (password == null)
					throw (new ArgumentException("Password null!"));
				#endregion

				if ( Exists(username) )
					return (false);

				PrivateUser user = new PrivateUser(username, password);

				usersTable.Add(user, false);
				offline = offline + 1;
				return (true);
			}

			private bool CheckCredentials(string username, string password) {
				User user = All.FirstOrDefault( x => (x.Username.Equals(username) && x.Password.Equals(password)) );
				return (user != null);
			}

			public bool Login(string username, string password) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Username null!"));
				if (password == null)
					throw (new ArgumentException("Password null!"));
				#endregion

				PrivateUser user = new PrivateUser(username, password);

				if ( !CheckCredentials(username, password) )
					return (false); // failed
				if ( usersTable[user] == true )
					return (false); // already online

				usersTable[user] = true;
				online = online + 1;
				offline = offline - 1;
				return (true); // successful
			}

			public bool Logout(string username, string password) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Username null!"));
				if (password == null)
					throw (new ArgumentException("Password null!"));
				#endregion

				PrivateUser user = new PrivateUser(username, password);

				if ( !CheckCredentials(username, password) )
					return (false); // failed
				if ( usersTable[user] == false )
					return (false); // already offline

				usersTable[user] = false;
				online = online - 1;
				offline = offline + 1;
				return (true); // successful
			}

			public User GetByUsername(string username) {
				#region Preconditions
				if (username == null)
					throw (new ArgumentException("Username null!"));
				#endregion

				return (All.FirstOrDefault( x => x.Username.Equals(username) ));
			}

			public bool Exists(string username) {
				User user = All.FirstOrDefault(x => x.Username.Equals(username));
				return (user != null);
			}

			public static Player NewComputer() {
				return (new PrivateComputer());
			}

		}

	}


}


