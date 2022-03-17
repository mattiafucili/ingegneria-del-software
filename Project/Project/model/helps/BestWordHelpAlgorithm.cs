using System;
using System.Collections.Generic;
using System.Linq;

namespace Project.model {

	public static partial class HelpStrategy {

		private class BestWordHelpAlgorithm : HelpAlgorithm {

			public string Name {
				get {
					return ("best");
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

				Word currentWord = null;
				int currentScore = 0;

				foreach (Word word in vocabulary.All)
					if (word.Name.StartsWith(lastWord.LastSyllable) && !wordsList.Contains(word)) {
						int score = word.Evaluate(charBonus);
						if (score > currentScore) {
							currentWord = word;
							currentScore = score;
						}
					}

				return (currentWord);
			}

		}

	}


}
