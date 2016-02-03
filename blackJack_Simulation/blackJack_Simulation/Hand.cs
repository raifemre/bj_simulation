using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Hand
    {
        private List<int> CardsInHand;

        public Hand()
        {
            CardsInHand = new List<int>();
        }
        
        public void AddCard(int cardValue)
        {
            CardsInHand.Add(cardValue);
        }

        //[0] = total, [1] = softTotal
        public int[] GetValues()
        {
            int total = 0, softTotal = 0;
            bool HasAce = false;

            for (int i = 0; i < CardsInHand.Count; ++i)
            {
                total += CardsInHand[i];
                if (CardsInHand[i] == 1)
                    HasAce = true;
            }
            if (HasAce && total < 12)
            {
                softTotal = total;
                softTotal += 10;
                if (softTotal == 21)
                    return new int[] { softTotal };
                return new int[] { total, softTotal };
            }
            return new int[] { total };
        }
    }
}
