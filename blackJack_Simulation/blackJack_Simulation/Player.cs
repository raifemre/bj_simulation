using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Player
    {
        public bool IsDealer { get; set; }
        public Hand _Hand = new Hand();

        public Player(bool isDealer)
        {
            IsDealer = isDealer;
        }
    }
}
