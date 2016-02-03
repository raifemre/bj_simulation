using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class SimulationEngine
    {
        public Shoe Shoe { get; private set; }
        public Player Player { get; private set; }
        public Player Dealer { get; private set; }
        public int CurrentBetAmount { get; private set; }
        public bool IsBlackJack { get; private set; }
        public bool IsPlayerBusted { get; private set; }
        public bool IsDealerBusted { get; private set; }

        public SimulationEngine(int deckAmount)
        {
            Shoe = new Shoe(deckAmount);
            Dealer = new Player(true,0);
            Player = new Player(false,10000);
            IsBlackJack = false;
            IsPlayerBusted = false;
            IsDealerBusted = false;
        }

        public void NewTurn(int bet)
        {
            CurrentBetAmount = bet;
            Player.Balance -= CurrentBetAmount;

            Player._Hand.Clear();
            Dealer._Hand.Clear();

            Shoe.Deal(Player._Hand);
            Shoe.Deal(Dealer._Hand);
            Shoe.Deal(Player._Hand);
            Shoe.Deal(Dealer._Hand);

            //TODO:[0] [1]
            if(Player._Hand.GetValues()[0] == 21)
            {
                IsBlackJack = true;
                DealerTurn();
            }

            PlayerTurn();
        }

        public void PlayerTurn()
        {
            if(Player._Hand.GetValues()[0] > 21)
            {
                IsPlayerBusted = true;
                DealerTurn();
            }

            //17 ThinkAction...
            MoveAction move = MoveAction.STAND;

            if(move == MoveAction.STAND)
                DealerTurn();
            else if (move == MoveAction.HIT)
            {
                Shoe.Deal(Player._Hand);
                PlayerTurn();
            }
            else if (move == MoveAction.DOUBLE)
            {
                if(Player.Balance > CurrentBetAmount)
                {
                    Shoe.Deal(Player._Hand);
                    DealerTurn();
                }
                else
                {
                    Shoe.Deal(Player._Hand);
                    PlayerTurn();
                }   
            }
        }

        public void DealerTurn()
        {

            if (Dealer._Hand.GetValues()[0] > 21)
            {
                IsDealerBusted = true;
                EndTurn();
            }
            else if (Dealer._Hand.GetValues()[0] < 17)
            {
                Shoe.Deal(Dealer._Hand);
                DealerTurn();
            }
            else
                EndTurn();
        }

        public void EndTurn()
        {
            int PlayerTotal = Player._Hand.GetValues()[0];
            int DealerTotal = Dealer._Hand.GetValues()[0];

            bool PlayerWins = false;
            if (PlayerTotal > DealerTotal)
                PlayerWins = true;
            if (IsDealerBusted) 
                PlayerWins = true;
            if (IsPlayerBusted) 
                PlayerWins = false;


            if (PlayerWins)
            {
                Player.Balance += CurrentBetAmount * 2;
                if (IsBlackJack)
                    Player.Balance += CurrentBetAmount;
            }

            IsBlackJack = false;
            IsDealerBusted = false;
            IsPlayerBusted = false;
        }
    }
}
