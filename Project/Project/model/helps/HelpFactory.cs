using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {


	public static class HelpFactory {

		public static Help BuildHelp(string username, string type) {
			#region Preconditions
			if (username == null)
				throw (new ArgumentException("Username null!"));
			if (type == null)
				throw (new ArgumentException("Help type null!"));
			if (!HelpStrategy.All.Contains(type))
				throw (new ArgumentException("Invalid help type!"));
			#endregion

			return ( new PrivateHelp(username, HelpStrategy.GetAlgorithm(type)) );
		}

		private class PrivateHelp : Help {
			private string username;
			private bool available;
			private HelpAlgorithm helpAlgorithm;

			public PrivateHelp(string username, HelpAlgorithm helpAlgorithm) {
				this.username = username;
				available = true;
				this.helpAlgorithm = helpAlgorithm;
			}

			public string Username {
				get {
					return username;
				}
			}

			public bool Available {
				get {
					return available;
				}
			}

			public Word GetHelp(IEnumerable<Word> wordsList, Word lastWord, char charBonus) {
				#region Preconditions
				if (wordsList == null)
					throw (new ArgumentException("Words list null!"));
				if (lastWord == null)
					throw (new ArgumentException("Last word null!"));
				if (!LetterFlyweight.All.Contains(charBonus))
					throw (new ArgumentException("Invalid bonus char!"));
				if (!Available)
					throw (new ArgumentException("Help not available!"));
				#endregion

				Word word = helpAlgorithm.GetWord(wordsList, lastWord, charBonus);
				available = false;
				return (word);
			}
		}

	}


}
