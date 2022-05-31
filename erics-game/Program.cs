using System;

namespace erics_game
{
    class Program
    {
        static void Main(string[] args)
        {

            OutputHelpers.OutputState();
            Console.ReadKey();

            while(PlayerState.Health > 0 && PlayerState.ShipFuel > 0)
            {
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
            PlayerState.Health = 0;
            PlayerState.Money = 1000.00m;
            PlayerState.ShipFuel = 100;

            GameState.FuelBurnRate = 1;
        }
    }
}

