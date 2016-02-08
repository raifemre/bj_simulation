using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Player
    {
        public List<Hand> Hands;
        public IPlayerMoveStrategy MoveStrategy;
        public IBetStrategy BetStrategy;
        public double Balance;
        public double BetAmount;

        public Player(IPlayerMoveStrategy moveStrategy, IBetStrategy betStrategy, int balance)
        {
            Hands = new List<Hand>();
            Hands.Add(new Hand());
            MoveStrategy = moveStrategy;
            BetStrategy = betStrategy;
            Balance = balance;
            BetAmount = balance / 100; // Default - Biraz özensiz oldu bu satır.
        }


        public bool HasBustedHand()
        {
            for (int i = 0; i < Hands.Count; i++)
                if (Hands[i].IsBusted)
                    return true;
            return false;
        }

        public bool HasSplittedHand()
        {
            return Hands.Count == 2;
        }

        public void ClearHands()
        {
            if (HasSplittedHand())
                Hands.RemoveAt(1);
            Hands[0].ClearHand();
        }
        
        public void SplitHand()
        {
            Card tempCard = Hands[0].Cards[1];
            Hand tempHand = new Hand();
            tempHand.AddCard(tempCard);
            Hands.Add(tempHand);
            Hands[0].Cards.RemoveAt(1); //.Remove(tempCard) yaparsak eğer 0. index'teki card'ı silebilir !
        }

        public Card LastDealtCard()
        {
            int lastIndexOfHands = Hands.Count - 1;
            Hand lastHand = Hands[lastIndexOfHands];
            return lastHand.Cards[lastHand.Cards.Count - 1];
        }

        //public void AddHand(List<Card> cards)
        //{
        //    Hand tempHand = new Hand();
        //    for (int i = 0; i < cards.Count; i++)
        //    {
        //        tempHand.AddCard(cards[i]);
        //    }
        //    Hands.Add(tempHand);

        //}
    }
}
