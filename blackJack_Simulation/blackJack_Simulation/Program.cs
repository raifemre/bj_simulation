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
            int games = 1000;
            double totalEdge = 0.00;

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();
            
            for (int i = 0; i < games; i++)
            {
                engine = new SimulationEngine(8, new List<Player>());
                engine.StartNewTurn();
                totalEarnings += engine.myPlayer.Balance;
                totalEdge += engine.edge;
            }

            Console.WriteLine(">>Balance: {0} [Total Games: {1}]", totalEarnings / games, games);
            Console.WriteLine("House Edge: {0}", totalEdge/ games);
            stopwatch.Stop();
            Console.WriteLine("Süre: {0}", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
