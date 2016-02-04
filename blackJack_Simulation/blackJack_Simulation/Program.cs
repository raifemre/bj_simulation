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

            List<Player> ExternalPlayers = new List<Player>();
            SimulationEngine engine = new SimulationEngine(8,ExternalPlayers);

            Console.WriteLine("Starting Balance: 10000 Bet Amount: {0}", betAmount);
            Console.WriteLine();

            
           engine.StartNewTurn(betAmount);
           //Console.WriteLine("P: {0}\tD: {1}\tBalance: {2}", engine.My._Hand.GetValues()[0], engine.Dealer._Hand.GetValues()[0], engine.My.Balance);
           

            Console.WriteLine("\nResult = {0}\tTotalRounds = {1}\n", engine.My.Balance - 10000,engine.TotalTurns);

            Console.ReadLine();
        }

      
    }
}
