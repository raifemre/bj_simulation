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
        public int Balance;        

        public Player(bool isDealer, int balance)
        {
            _Hand = new Hand(IsDealer);
            IsDealer = isDealer;
            Balance = balance;
        }
    }
}
