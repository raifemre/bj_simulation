using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class HiLoBetStrategy : IBetStrategy
    {
        public double Response(double initialBet , bool wonLastTurn, int[] cardAmounts)
        {
            int RunningCount = 0;
            double TrueCount = 0.0;
            double RemainingDeck = 8.00;
            int[] PlayedCards = new int[14];

            
            for (int i = 0; i < cardAmounts.Length; i++)
            {
                //Console.Write(" " + cardAmounts[i] + " ");
                if (i == 0)
                {
                    PlayedCards[i] = 416 - cardAmounts[i];
                }
                else
                {
                    PlayedCards[i] = 32 - cardAmounts[i];
                }
                //Console.Write(" " + PlayedCards[i] + " ");
            }
           
            for (int i = 0; i < PlayedCards.Length; i++)
            {
                if(i == 2 || i == 3 || i == 4 || i == 5 || i == 6)
                {
                    RunningCount += PlayedCards[i];
                }
                else if (i == 10 || i == 11 || i == 12 || i == 13 || i == 1)
                {
                    RunningCount -= PlayedCards[i];
                }
                else
                {
                    RunningCount += 0;
                }
            }

            RemainingDeck = (double)cardAmounts[0] / 52;
            TrueCount = RunningCount / RemainingDeck;
            Console.WriteLine("Running Count: {0}\t True Count: {1} ", RunningCount, TrueCount);
            if (TrueCount < 1) TrueCount = 1;
            return TrueCount;
        }
    }
}
