using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Dealer
    {
        public IDealerMoveStrategy MoveStrategy;
        public Hand _Hand;
        public bool ClosedCardTurned; //Güzel isim bulamadım

        public Dealer(IDealerMoveStrategy move)
        {
            _Hand = new Hand();
            MoveStrategy = move;
        }

        public void TurnClosedCard() //Güzel isim bulamadım
        {
            ClosedCardTurned = true;
        }

        public void ClearHand()
        {
            _Hand.ClearHand();
            ClosedCardTurned = false;
        }

        public Card LastDealtCard()
        {
            int lastIndexOfHand = _Hand.Cards.Count - 1;
            return _Hand.Cards[lastIndexOfHand];
        }
    }
}
