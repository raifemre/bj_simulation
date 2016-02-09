using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Hand
    {
        public List<Card> Cards;
        public bool IsBusted;
        public bool IsBlackjack;
        public bool IsCompleted;
        public bool IsDoubled;

        public Hand()
        {
            Cards = new List<Card>();
        }

     
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public void ClearHand()
        {
            Cards.Clear();
            IsBusted = false;
            IsBlackjack = false;
            IsCompleted = false;
            IsDoubled = false;
        }

        //[0] = total, [1] = softTotal
        public int[] GetValues()
        {
            int total = 0, softTotal = 0;
            bool HasAce = false;

            for (int i = 0; i < Cards.Count; ++i)
            {
                total += Cards[i].GetCardValue();
                if (Cards[i] == Card.Ace)
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
