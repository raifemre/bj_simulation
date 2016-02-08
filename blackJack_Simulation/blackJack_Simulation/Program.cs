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

            List<Player> ExternalPlayers = new List<Player>();
            SimulationEngine engine;

            for (int i = 0; i < 10; i++)
            {
                engine = new SimulationEngine(8, ExternalPlayers);
                engine.StartNewTurn();
            }
            
            
            Console.ReadLine();
        }
    }
}
