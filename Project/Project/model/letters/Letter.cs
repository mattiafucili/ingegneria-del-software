
namespace Project.model {


	public interface Letter {

		// Properties
		char Character { get; }
		int BaseScore { get; }
		BonusAlgorithm BonusAlgorithm { get; set; }

		// Methods
		int GetScore(char charBonus);
	}


}
