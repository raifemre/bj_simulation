using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //int betAmount = 100; -- Default = Balance / 100
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            
            SimulationEngine engine;
            double totalEarnings = 0;

            
            for (int i = 0; i < 1; i++)
            {
                engine = new SimulationEngine(8, new List<Player>());
                engine.StartNewTurn();
                totalEarnings += engine.myPlayer.Balance;
            }

            Console.WriteLine(">>Balance: {0}", totalEarnings / 1); // 1. 8388 / 2. 8461  / 3. 8455 / 4. 8456 / 5. 8468  / 6. 8519 /  7. 8526  / 8. 8379 / 9. 8352  / 10. 8428
            
            Console.ReadLine();
        }
    }
}
