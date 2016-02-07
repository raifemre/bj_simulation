

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Player
    {
        public bool IsDealer { get; set; }
        public bool IsMe { get; set; }
        public Hand _Hand;
        public List<Hand> Hands;
        public int Balance;
        public int PlayStrategy;
        public int BetStrategy;

        public Player(bool isDealer, bool isMe, int playStrategy, int betStrategy, int balance)
        {
            //_Hand = new Hand(IsDealer);  - IsDealer yollamak pek mantıklı değil?, değiştirdim.
            Hands = new List<Hand>();
            _Hand = new Hand();
            Hands.Add(_Hand);
            IsDealer = isDealer;
            Balance = balance;
            IsMe = isMe;
            PlayStrategy = playStrategy;
            BetStrategy = betStrategy;
        }

        public Card LastCard(Hand hand)
        {
            return hand.AllCards[hand.AllCards.Count-1];
        }
        public void AddHand(List<Card> cards)
        {
            Hand tempHand = new Hand();
            for (int i = 0; i < cards.Count; i++)
            {
                tempHand.AddCard(cards[i]);
            }
            Hands.Add(tempHand);
            
        }
        public Boolean IsSplitted()
        {
            return Hands.Count == 2;
        }

        public void Split()
        {
            Card tempCard = _Hand.AllCards[1];
            Hand tempHand = new Hand();
            tempHand.AddCard(tempCard);
            _Hand.AllCards.Remove(tempCard);
            Hands.Add(tempHand);

        }
    }
}