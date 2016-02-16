using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class HiLoBetStrategy : IBetStrategy
    {
        private double[] cardAmounts;

        public HiLoBetStrategy(double[] cardAmounts)
        {
            this.cardAmounts = cardAmounts;
        }

        public double Response(double initialBet, bool wonLastTurn)
        {
            double runningCount = 0;
            double trueCount = 0.0;
            double remainingDeck = 8.00;
            double[] playedCards = new double[14];


            for (int i = 0; i < cardAmounts.Length; i++)
            {
                //Console.Write(" " + cardAmounts[i] + " ");
                if (i == 0)
                {
                    playedCards[i] = 416d - cardAmounts[i];
                }
                else
                {
                    playedCards[i] = 32d - cardAmounts[i];
                }
                //Console.Write(" " + PlayedCards[i] + " ");
            }

            for (int i = 0; i < playedCards.Length; i++)
            {
                if (i == 2 || i == 3 || i == 4 || i == 5 || i == 6)
                {
                    runningCount += playedCards[i];
                }
                else if (i == 10 || i == 11 || i == 12 || i == 13 || i == 1)
                {
                    runningCount -= playedCards[i];
                }
                else
                {
                    runningCount += 0;
                }
            }

            remainingDeck = (double)cardAmounts[0] / 52;
            trueCount = runningCount / remainingDeck;
            //Console.WriteLine("Running Count: {0}\t True Count: {1} ", RunningCount, TrueCount);
            if (trueCount < 1) trueCount = 1;
            return 1;
        }
    }
}
