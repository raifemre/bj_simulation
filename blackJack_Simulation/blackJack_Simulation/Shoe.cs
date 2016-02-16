using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BlackjackSimulation
{
    class Shoe
    {
        private int _deckAmount;
        public double[] CardAmounts;
        public Stack<Card> Cards;
        public int CutCardIndex;

        public Shoe(int deckAmount)
        {
            _deckAmount = deckAmount;
            GenerateShoe();
        }

        private void GenerateShoe()
        {
            List<Card> tempList = new List<Card>();

            for (int i = 1; i < 14; i++)
                for (int j = 0; j < 4 * _deckAmount; j++)
                    tempList.Add((Card)i);

            //Shuffled cards, shoe
            Cards = new Stack<Card>();

            int size = tempList.Count;

            for (int i = 0; i < size; i++)
            {
                int rand = NextInt(0, tempList.Count - 1);
                Cards.Push(tempList[rand]);
                tempList.RemoveAt(rand);
            }

            //Total Card Amounts
            //[0] = Total amount of cards, [1] = A, .... [10] = T, [11] = J, [12] = Q, [13] = K
            CardAmounts = new double[14];
            CardAmounts[0] = _deckAmount * 52;
            for (int i = 1; i < CardAmounts.Length; i++)
                CardAmounts[i] = _deckAmount * 4;

            CutCardIndex = (_deckAmount * 52) * NextInt(45, 55) / 100;

        }
                      
        private int NextInt(int min, int max)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);

            return new Random(result).Next(min, max);
        }


        public void Deal(Hand hand)
        {
            Card card = Cards.Pop();
            hand.AddCard(card);
        }

    }
}
