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
        private Stack<int> _cards;
        private List<int> _cardsList;
       
        public Shoe(int deckAmount)
        {
            _deckAmount = deckAmount;
            GenerateShoe();
        }

        public Stack<int> GetCards()
        {
            return _cards;
        }

        public void GenerateShoe()
        {
            //Ordered list of cards
            _cardsList = new List<int>();

            for (int i = 1; i < 10; i++)
                for (int j = 0; j < 4 * _deckAmount; j++)
                    _cardsList.Add(i);

            for (int i = 0; i < 4 * 4 * _deckAmount; i++)
                _cardsList.Add(10);

            //Shuffled cards, shoe
            _cards = new Stack<int>();

            int size = _cardsList.Count;

            for (int i = 0; i < size; i++)
            {
                int rand = NextInt(0, _cardsList.Count - 1);
                _cards.Push(_cardsList[rand]);
                _cardsList.RemoveAt(rand);
            }
        }
                      
        private int NextInt(int min, int max)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);

            return new Random(result).Next(min, max);
        }
    }
}
