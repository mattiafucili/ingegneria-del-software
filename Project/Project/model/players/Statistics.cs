using System;

namespace Project.model {


	public interface Statistics {
		
		// Properties
		string Difficulty { get; }
		int Count { get; }
		int Win { get; }
		int Defeat { get; }
		int Draw { get; }
		int TotalScore { get; }
		int MaximumScore { get; }
		double AverageScore { get; }

		// Methods
		void Add(DateTime date, GameState gameState, int score);
	}


}