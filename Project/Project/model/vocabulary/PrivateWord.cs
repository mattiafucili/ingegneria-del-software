using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {


	public partial class Vocabulary {

		private class PrivateWord : Word {
			private readonly string name;
			private readonly List<Letter> letters;
			private readonly string lastSyllable;

			public PrivateWord(string name, string lastSyllable) {
				#region Preconditions
				if (name == null)
					throw (new ArgumentException("Class 'Word': name null!"));
				if (lastSyllable == null)
					throw (new ArgumentException("Class 'Word': lastSyllable null!"));
				foreach (char character in name)
					if (!LetterFlyweight.All.Contains(character))
						throw (new ArgumentException("Class 'Word': invalid word name!"));
				#endregion

				this.name = name;
				letters = new List<Letter>();
				foreach (char character in name)
					letters.Add(LetterFlyweight.GetLetter(character));
				this.lastSyllable = lastSyllable;
			}

			public string Name {
				get {
					return (name);
				}
			}

			public string LastSyllable {
				get {
					return (lastSyllable);
				}
			}

			public int Evaluate(char charBonus) {
				#region Preconditions
				if (!LetterFlyweight.All.Contains(charBonus))
					throw (new ArgumentException("Class 'PrivateWord': invalid bonus character!"));
				#endregion

				int value = 0;
				foreach (Letter letter in letters)
					value = value + letter.GetScore(charBonus);
				return (value);
			}

			public override bool Equals(object obj) {
				if (obj is PrivateWord) {
					PrivateWord that = (PrivateWord) obj;
					return (Name.Equals(that.Name));
				}
				return (false);
			}

			public override int GetHashCode() {
				return (Name.GetHashCode());
			}

			public override string ToString() {
				return (Name);
			}
		}

	}


}

