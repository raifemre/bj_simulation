using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class BasicStrategy : IPlayerMoveStrategy
    {

        public const MoveAction H = MoveAction.Hit; // HIT
        public const MoveAction S = MoveAction.Stand; // STAY        
        public const MoveAction DH = MoveAction.Double; // DOUBLE, else HIT
        public const MoveAction DS = MoveAction.Double; // DOUBLE, else STAY
        public const MoveAction P = MoveAction.Split; // SPLIT
        public const MoveAction PH = MoveAction.Hit; // SPLIT if double after split allowed, else HIT
        public const MoveAction RH = MoveAction.Hit; // SURRENDER if allowed, else HIT
        public const MoveAction K = MoveAction.Stand;
        private static MoveAction[,] hardStrategy = {
        //   0  1  2  3  4  5  6  7  8  9 10
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //0
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //1
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //2
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //3
            {0, H, H, H, H, H, H, H, H, H, H}, //4
            {0, H, H, H, H, H, H, H, H, H, H}, //5
            {0, H, H, H, H, H, H, H, H, H, H}, //6
            {0, H, H, H, H, H, H, H, H, H, H}, //7
            {0, H, H, H, H, H, H, H, H, H, H}, //8
            {0, H, H,DH,DH,DH,DH, H, H, H, H}, //9
            {0, H,DH,DH,DH,DH,DH,DH,DH,DH, H}, //10
            {0, H,DH,DH,DH,DH,DH,DH,DH,DH,DH}, //11
            {0, H, H, H, S, S, S, H, H, H, H}, //12
            {0, H, S, S, S, S, S, H, H, H, H}, //13            
            {0, H, S, S, S, S, S, H, H, H, H}, //14
            {0, H, S, S, S, S, S, H, H, H,RH}, //15
            {0,RH, S, S, S, S, S, H, H,RH,RH}, //16
            {0, S, S, S, S, S, S, S, S, S, S}, //17
            {0, S, S, S, S, S, S, S, S, S, S}, //18
            {0, S, S, S, S, S, S, S, S, S, S}, //19
            {0, S, S, S, S, S, S, S, S, S, S}, //20
            {0, S, S, S, S, S, S, S, S, S, S}  //21  
        };
        private static MoveAction[,] softStrategy = {
        //   0  1  2  3  4  5  6  7  8  9 10
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //0
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //1
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //2 
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //3           
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //4
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //5
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //6
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //7
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //8
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //9
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //10
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //11
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //12
            {0, H, H, H, H,DH,DH, H, H, H, H}, //13
            {0, H, H, H, H,DH,DH, H, H, H, H}, //14
            {0, H, H, H,DH,DH,DH, H, H, H, H}, //15
            {0, H, H, H,DH,DH,DH, H, H, H, H}, //16
            {0, H, H,DH,DH,DH,DH, H, H, H, H}, //17
            {0, H, S,DS,DS,DS,DS, S, S, H, H}, //18
            {0, S, S, S, S, S, S, S, S, S, S}, //19
            {0, S, S, S, S, S, S, S, S, S, S}, //20
            {0, S, S, S, S, S, S, S, S, S, S}, //21
        };
        private static MoveAction[,] splitStrategy = {
        //   0  1  2  3  4  5  6  7  8  9  10
            {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}, //0
            {0, P, P, P, P, P, P, P, P, P, P}, //1
            {0, H,PH,PH, P, P, P, P, H, H, H}, //2
            {0, H,PH,PH, P, P, P, P, H, H, H}, //3
            {0, H, H, H, H,PH,PH, H, H, H, H}, //4
            {0, K, K, K, K, K, K, K, K, K, K}, //5
            {0, H,PH, P, P, P, P, H, H, H, H}, //6
            {0, H, P, P, P, P, P, P, H, H, H}, //7
            {0, P, P, P, P, P, P, P, P, P, P}, //8
            {0, S, P, P, P, P, P, S, P, P, S}, //9
            {0, K, K, K, K, K, K, K, K, K, K}, //10
        };

        public MoveAction Response(Hand hand, Card dealerUpCard, bool HasSplittedHand)
        {
            int playerHardTotal = hand.GetValues()[0];

            MoveAction hardResponse = hardStrategy[playerHardTotal, dealerUpCard.GetCardValue()];
            MoveAction softResponse = softStrategy[playerHardTotal, dealerUpCard.GetCardValue()];

            //  TODO: hand.getvalues lenght 2 ise hand softtur. 

            if (hand.Cards.Count == 2 && !HasSplittedHand && hand.Cards[0].GetCardValue() == hand.Cards[1].GetCardValue())  // Split Hands
            {
                return splitStrategy[playerHardTotal/2, dealerUpCard.GetCardValue()];
            }
            else if(hand.GetValues().Length > 1) // Soft hands
            {
                if(softResponse == MoveAction.Double && hand.Cards.Count > 2 && !HasSplittedHand)   // 1. response double + kart sayısı 2 den fazla ise = HIT  2. hand splitted + response double = HIT 
                {
                    return MoveAction.Hit;
                }
                else
                {
                    return softResponse;
                }
            }
            else // Hard hands
            {
                if (hardResponse == MoveAction.Double && hand.Cards.Count > 2 && !HasSplittedHand)
                {
                    return MoveAction.Hit;
                }
                else
                {
                    return hardResponse;
                }
            }
            
        }
    }
}
 