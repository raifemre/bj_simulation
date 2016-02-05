using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Hand
    {
        //List<Card>[] AllCards = new List<Card>[2]; - Split durumu için. List<Card> tutan bir array'e çevrilecek !
        public List<Card> AllCards;
        public bool IsBusted;
        //public bool IsSplitted; ?


        //public bool IsDealer { get; private set; }

        public Hand()
        {
            AllCards = new List<Card>();
            //IsDealer = isDealer;
        }


        public void AddCard(Card card)
        {
            AllCards.Add(card);
        }

        public void Clear()
        {
            AllCards.Clear();
        }

        //[0] = total, [1] = softTotal
        public int[] GetValues()
        {
            int total = 0, softTotal = 0;
            bool HasAce = false;

            for (int i = 0; i < AllCards.Count; ++i)
            {
                total += AllCards[i].GetCardValue();
                if (AllCards[i] == Card.Ace)
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
