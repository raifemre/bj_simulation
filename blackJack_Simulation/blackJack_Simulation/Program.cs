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
            int betAmount = 200;
            SimulationEngine engine = new SimulationEngine(8);

            Console.WriteLine("Starting Balance: 10000 Bet Amount: {0}", betAmount);
            Console.WriteLine();

            for (int i = 0; i < 30; i++)
            {
                engine.Start(betAmount);
                Console.WriteLine("P: {0}\tD: {1}\tBalance: {2}", engine.My._Hand.GetValues()[0], engine.Dealer._Hand.GetValues()[0], engine.My.Balance);
            }

            Console.WriteLine("\nResult = {0}\n", engine.My.Balance - 10000);
        }
    }
}
