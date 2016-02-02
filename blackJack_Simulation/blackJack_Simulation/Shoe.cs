using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackSimulation
{
    class Shoe
    {
        private int _deckAmount;
        private int _totalCards;
        public int[] Cards;

        public Shoe(int deckAmount)
        {
            _deckAmount = deckAmount;
            _totalCards = _deckAmount * 52;
            Cards = new int[11];
            GenerateDeck();
        }

        public void GenerateDeck()
        {
            Cards[0] = _totalCards;
            Cards[10] = 4 * 4 * _deckAmount;

            for (int i = 1; i < 10; i++)
                Cards[i] = 4 * _deckAmount;
        }
    }
}
