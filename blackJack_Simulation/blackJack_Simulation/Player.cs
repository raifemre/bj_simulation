using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Player
    {
        public bool IsDealer { get; set; }
        public Hand _Hand;
        public Decimal balance;
        

        public Player(bool isDealer)
        {
            IsDealer = isDealer;
            _Hand = new Hand(IsDealer);
            this.balance = 1000;
        }
    }
}
