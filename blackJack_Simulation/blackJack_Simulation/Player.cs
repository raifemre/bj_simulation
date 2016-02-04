

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
        public int Balance;
        public int PlayStrategy;
        public int BetStrategy;

        public Player(bool isDealer, bool isMe, int playStrategy, int betStrategy, int balance)
        {
            _Hand = new Hand(IsDealer);
            IsDealer = isDealer;
            Balance = balance;
            IsMe = isMe;
            PlayStrategy = playStrategy;
            BetStrategy = betStrategy;
        }

        public Card LastCard()
        {
            return _Hand.AllCards[_Hand.AllCards.Count-1];
        }
    }
}