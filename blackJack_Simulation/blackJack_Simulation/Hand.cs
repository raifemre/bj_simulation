using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Hand
    {
       //TODO: public List<Card>[] AllCards; - Bu şekilde bir array'e dönüştürmeliyiz Split durumu için.
        public List<Card> AllCards;
        public bool IsBusted;
        public bool IsSplitted;

        public Hand()
        {
            //AllCards = new List<Card>[2];
            AllCards = new List<Card>();
        }

        public void Split()
        {
            //2 farklı listeye bölünecek..
            IsSplitted = true;
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
