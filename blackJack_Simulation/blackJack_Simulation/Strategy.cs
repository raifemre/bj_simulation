using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    static class Strategy
    {
        public static int[] CardAmounts;

        static Strategy()
        {
            CardAmounts = new int[14];
        }

        public static int BetStrategyResponse()
        {
            //Tek bakacağı şey kart sayıları..
            return 200;
        }

        public static MoveAction MoveStrategyResponse(Hand playerHand, Card dealerUpCard, params Hand[] otherPlayersHands) //gerçi burda diğer oyuncuların elleriyle bi işimiz yok. turnuva stratejisi yaparsak kullanılır bu şekilde..
        {
            MoveAction moveResponse;
            if (playerHand.GetValues()[0] < 14)
                moveResponse = MoveAction.HIT;
            else
                moveResponse = MoveAction.STAND;
            return moveResponse;
        }
    }
}

