using System;

namespace Project.model {

	public abstract class Player {
		private readonly string username;
		private Game currentGame;

		public event EventHandler GameStarted;

		public Player(string username) {
			#region Preconditions
			if (username == null) 
				throw (new ArgumentException("Username null!"));
			#endregion

			this.username = username;
			currentGame = null;
		}

		public string Username {
			get {
				return (username);
			}
		}
		
		public Game CurrentGame {
			get {
				return (currentGame);
			}
			set {
				#region Preconditions
				if (CurrentGame != null && value != null)
					throw (new ArgumentException(Username + " is already playing!"));
				#endregion

				currentGame = value;
				if ( CurrentGame != null )
					OnGameStarted();
			}
		}

		public override bool Equals(object obj) {
			if (obj is Player) {
				Player that = (Player) obj;
				return (Username.Equals(that.Username));
			}
			return (false);
		}

		public override int GetHashCode() {
			return (Username.GetHashCode());
		}

		public override string ToString() {
			return (Username);
		}

		private void OnGameStarted() {
			if ( GameStarted != null )
				GameStarted(this, EventArgs.Empty);
		}

	}


}
