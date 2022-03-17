
namespace Project.model {


	public interface BonusAlgorithm {

		string Name { get; }
		int CalculateBonus(int score);

	}


}
