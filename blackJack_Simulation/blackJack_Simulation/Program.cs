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
            

            List<Player> ExternalPlayers = new List<Player>();
            SimulationEngine engine;

           
            engine = new SimulationEngine(8, ExternalPlayers);
            engine.StartNewTurn();
            
            Console.ReadLine();
        }
    }
}
