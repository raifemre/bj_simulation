using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    //TODO: http://www.blackjackclassroom.com/wp-content/uploads/2009/12/blackjack-basic-strategy.png

    class BasicStrategy : IPlayerMoveStrategy
    {
        public MoveAction Response(Hand hand, Card dealerUpCard, bool HasSplittedHand)
        {
            return MoveAction.Hit;
        }
    }
}
