using System;
using System.Collections.Generic;

namespace erics_game
{
	/*
	 * This file consists of methods to output to the console.
	 */
	public static class OutputHelpers
	{
		const string _alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		public static void OutputOptions(List<Option> options)
        {
			// This takes in a list of Option objects and outputs them as [SomeLetter]) [Some option text
			for (var i = 0; i < options.Count; i++)
            {
				Console.WriteLine("${0}) ${1}", _alphabet[i], options[i].text);
            };
        }

		public static void OutputPlayerState()
        {
			// This outputs the player state to the console
			Console.WriteLine(' ');
			Console.WriteLine("Status: ${0}% Health - ${1}% Fuel - $${2}", PlayerState.Health, PlayerState.ShipFuel, PlayerState.Money);
			Console.WriteLine(' ');
		}

		public static void EmptyLine()
        {
			// Prints an empty line
			Console.WriteLine(' ');
        }

		public static void WriteAndAddSpace(string toWrite)
        {
			// Write some string and pad with bottom space.
			Console.WriteLine(toWrite);
			Console.WriteLine(' ');
		}
	}	
}

