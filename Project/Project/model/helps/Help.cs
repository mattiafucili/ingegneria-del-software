using System.Collections.Generic;

namespace Project.model {


	public interface Help {

		// Properties
		bool Available { get; }
		string Username { get; }

		// Methods
		Word GetHelp(IEnumerable<Word> wordsList, Word lastWord, char charBonus);
	}


}
