using System;
using System.Collections.Generic;

namespace erics_game
{
	public class GameStep
	{
		public GameStep(string _text = "", string _action = "", List<Option> _options = null)
        {
			text = _text;
			action = _action;
			options = _options;
        }

		public string text { get; set; }
		public string action { get; set; }
		public List<Option> options { get; set; }
	}

	public class Option
    {
		public Option(string _text, PlayerUpdates _playerUpdate, GameUpdates _gameUpdates)
        {
			text = _text;
			playerUpdates = _playerUpdate;
			gameUpdates = _gameUpdates;
        }

		public string text { get; set; }
		public PlayerUpdates playerUpdates { get; set; }
		public GameUpdates gameUpdates { get; set; }

	}

	public class PlayerUpdates
    {
		public PlayerUpdates(int _changeHealthBy, int _changeFuelBy, decimal _changeMoneyBy)
        {
			changeHealthBy = _changeHealthBy;
			changeFuelBy = _changeFuelBy;
			changeMoneyBy = _changeMoneyBy;
		}

		public int changeHealthBy { get; set; }
		public int changeFuelBy { get; set; }
		public decimal changeMoneyBy { get; set; }
	}

	public class GameUpdates
    {
		public GameUpdates(decimal _changeFuelRate)
        {
			changeFuelRate = _changeFuelRate;
        }

		public decimal changeFuelRate { get; set; }
	}
}

