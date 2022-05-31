using System;
using System.Collections.Generic;

namespace erics_game
{
	public static class GameFlow
	{
		static GameFlow()
        {
			thisGame = buildGame();
        }

		public static List<GameStep> thisGame = new List<GameStep>();

		private static List<GameStep> buildGame()
        {
			List<GameStep> game = new List<GameStep>();

			GameStep step = new GameStep();

			step.text = @"You board your ship in your mythical dystopian life.";

			step.action = "You decide to:";

			List<Option> options = new List<Option>();

			options.Add(buildOption("Stab yourself through the heart", buildPlayerUpdates(100, 0, 0), buildGameUpdates(0)));
			options.Add(buildOption("Dump all your fuel", buildPlayerUpdates(0, 100, 0), buildGameUpdates(0)));
			step.options = options;

			return game;
        }

		private static PlayerUpdates buildPlayerUpdates(int changeHealthBy, int changeFuelBy, decimal changeMoneyBy)
		{
			return new PlayerUpdates(changeHealthBy, changeFuelBy, changeMoneyBy);
        }

		private static GameUpdates buildGameUpdates(decimal fuelBurnRate)
		{
			return new GameUpdates(fuelBurnRate);
		}

		private static Option buildOption(string text, PlayerUpdates playerUpdates, GameUpdates gameUpdate)
        {
			return new Option(text, playerUpdates, gameUpdate);
        }
	}
}

