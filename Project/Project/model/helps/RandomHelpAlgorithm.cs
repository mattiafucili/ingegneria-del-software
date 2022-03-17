using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {

	public static partial class HelpStrategy {

		private class RandomHelpAlgorithm : HelpAlgorithm {
			private readonly Random random;

			public RandomHelpAlgorithm() {
				random = new Random();
			}

			public string Name {
				get {
					return ("random");
				}
			}

			public Word GetWord(IEnumerable<Word> wordsList, Word lastWord, char charBonus) {
				#region Preconditions
				if (wordsList == null)
					throw (new ArgumentException("Words list null!"));
				if (lastWord == null)
					throw (new ArgumentException("Last word null!"));
				if (!LetterFlyweight.All.Contains(charBonus))
					throw (new ArgumentException("Invalid bonus char!"));
				#endregion

				Vocabulary vocabulary = Vocabulary.GetInstance();
				List<Word> possibilities = new List<Word>();
				foreach (Word word in vocabulary.All)
					if (word.Name.StartsWith(lastWord.LastSyllable) && !wordsList.Contains(word))
						possibilities.Add(word);
				int index = random.Next(0, possibilities.Count);
				return (possibilities[index]);
			}

		}

	}

}
