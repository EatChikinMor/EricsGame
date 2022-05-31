using System;

namespace erics_game
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is the entry point of the program. The entirety of the program from start to end exists here, and it calls external methods to progress and do more complex things.
            Initialize();
            OutputHelpers.OutputPlayerState();
            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();

            while(PlayerState.Health > 0 && PlayerState.ShipFuel > 0)
            {
                // If you set Health and Ship Fuel to not be zero
                // in its current state it will execute an inifnite loop
                // as getNext doesn't do anything to update these values currently.
                Decisions.getNext();
            }

            if (PlayerState.Health == 0)
            {
                Console.WriteLine("Dead");
            }
            else
            {
                Console.WriteLine("Stranded");
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            Environment.Exit(0);
        }

        static void Initialize()
        {
            //This establishes the state variables
            PlayerState.Health = 0;
            PlayerState.Money = 1000.00m;
            PlayerState.ShipFuel = 100;

            GameState.FuelBurnRate = 1;
        }
    }
}

