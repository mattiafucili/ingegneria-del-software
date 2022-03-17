
namespace Project.model {


	public interface Word {

		// Properties
		string Name { get; }
		string LastSyllable { get; }

		// Method
		int Evaluate(char charBonus);

	}


}