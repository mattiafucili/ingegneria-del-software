using System.Collections.Generic;

namespace Project.model {


	public interface HelpAlgorithm {

		// Properties
		string Name { get; }

		// Methods
		Word GetWord(IEnumerable<Word> wordsList, Word lastWord, char charBonus);
	}


}