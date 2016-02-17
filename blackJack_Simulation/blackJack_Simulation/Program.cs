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
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            SimulationEngine engine;
            
            double totalEarnings = 0;
            int turns = 1000;

            //System.Diagnostics.Stopwatch stopwatch= new System.Diagnostics.Stopwatch();
            //stopwatch.Start();
            
            for (int i = 0; i < turns; i++)
            {
                engine = new SimulationEngine(8, new List<Player>());
                engine.StartNewTurn();
                totalEarnings += engine.myPlayer.Balance;
            }

            Console.WriteLine(">>Balance: {0} [Turns: {1}]", totalEarnings / turns, turns);

            //stopwatch.Stop();
            //Console.WriteLine("Süre: {0}",stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
