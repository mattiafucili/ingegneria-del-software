using System;
using System.Collections.Generic;

namespace Project.model {


	public enum GameState {
		NOT_SET = 0,
		WIN = 1,
		DEFEAT = 2,
		DRAW = 3
	}

	public interface Game {

		// Properties
		IEnumerable<Player> Players { get; }
		GameState GetState(string player);
		int GetScore(string player);
		string CurrentPlayer { get; }
		bool IsEnded { get; }
		DateTime StartTime { get; }
		string Difficulty { get; }
		IEnumerable<Word> WordsList { get; }
		Word LastWord { get; }
		char CharBonus { get; }
		
		// Events
		event EventHandler GameChanged;
		event UserEvent PlayersStateChanged;

		// Methods
		bool Play(string player, string word);
		bool HasHelp(string usename);
		string GetHelp(string username);
		void GiveUp(string username);
	}


}