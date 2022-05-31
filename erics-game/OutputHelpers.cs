using System;
using System.Collections.Generic;

namespace erics_game
{
	public static class OutputHelpers
	{
		const string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		public static void OutputOptions(List<Option> options)
        {
			for (var i = 0; i < options.Count; i++)
            {
				Console.WriteLine("${0}) ${1}", _alphabet[i], options[i].text);
            };
        }

		public static void OutputState()
        {
			Console.WriteLine(' ');
			Console.WriteLine("Status: ${0}% Health - ${1}% Fuel - $${2}", PlayerState.Health, PlayerState.ShipFuel, PlayerState.Money);
			Console.WriteLine(' ');
		}

		public static void EmptyLine()
        {
			Console.WriteLine(' ');
        }

		public static void WriteAndAddSpace(string toWrite)
        {
			Console.WriteLine(toWrite);
			Console.WriteLine(' ');
		}
	}	
}

