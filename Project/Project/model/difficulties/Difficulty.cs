
namespace Project.model {


	public interface Difficulty {

		// Properties
		string Name { get; }
		string DisplayName { get; }
		int Probability { get; }

		// Methods
		bool Answer();
	}


}
