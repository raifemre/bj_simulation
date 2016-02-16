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
        public bool HoleCardShowed;

        public Dealer(IDealerMoveStrategy move)
        {
            _Hand = new Hand();
            MoveStrategy = move;
        }

        public void ShowHoleCard()
        {
            HoleCardShowed = true;
        }

        public void ClearHand()
        {
            _Hand.ClearHand();
            HoleCardShowed = false;
        }

        public Card LastDealtCard()
        {
            int lastIndexOfHand = _Hand.Cards.Count - 1;
            return _Hand.Cards[lastIndexOfHand];
        }
    }
}
