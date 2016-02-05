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
            int betAmount = 100;
            int profit = 0;
            int iteration = 10000;

            List<Player> ExternalPlayers = new List<Player>();
            SimulationEngine engine;

            for (int i = 0; i < iteration; i++)
            {
                engine = new SimulationEngine(8, ExternalPlayers);
                engine.StartNewTurn(betAmount);
                profit += engine.My.Balance - 10000;
            }

            Console.WriteLine("Total Profit:\t\t{0}TL  ({1}TL/session)", profit, profit / iteration);
            Console.WriteLine();
        }
    }
}



//Console.WriteLine("P: {0}\tD: {1}\tBalance: {2}", engine.My._Hand.GetValues()[0], engine.Dealer._Hand.GetValues()[0], engine.My.Balance);         
//Console.WriteLine("\nProfit = {0}\tTotalRounds = {1}\n", engine.My.Balance - 10000,engine.TotalTurns);