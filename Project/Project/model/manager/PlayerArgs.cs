using System;
using System.Collections.Generic;

namespace Project.model {


	public class PlayerArgs : EventArgs {
		private List<Player> players;

		public List<Player> Players {
			get {
				return (players);
			}
			set {
				players = value;
			}
		}

	}


}
