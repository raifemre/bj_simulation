using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class SimulationEngine
    {
        
        public SimulationEngine(int deckAmount)
        {
            this.Shoe = new Shoe(deckAmount);
            this.Dealer = new Player(true);
            this.Player = new Player(false);
            this.IsBlackJack = false;
            this.PlayerBusted = false;
            this.DealerBusted = false;
        }

        public enum GameAction
        {
            HIT = 1,
            DOUBLE = 2,
            STAND = 3,
            SPLIT = 4
        }

        public Player Player { get; private set; }

        public Player Dealer { get; private set; }

        public Shoe Shoe { get; private set; }

        public int Bet { get; private set; }

        public bool IsBlackJack { get; private set; }

        public bool PlayerBusted { get; private set; }

        public bool DealerBusted { get; private set; }


        public void NewTurn(int Betson)
        {
            this.Bet = Betson;
            Player.Balance -= Bet;

            Player._Hand.Clear();
            Dealer._Hand.Clear();

            Shoe.Draw(Player._Hand);
            Shoe.Draw(Dealer._Hand);
            Shoe.Draw(Player._Hand);
            Shoe.Draw(Dealer._Hand);

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
                PlayerBusted = true;
                DealerTurn();
            }

            GameAction response = GameAction.STAND;

            if(response == GameAction.STAND)
            {
                DealerTurn();
            }
            else if (response == GameAction.HIT)
            {
                Shoe.Draw(Player._Hand);
                PlayerTurn();
            }
            else if (response == GameAction.DOUBLE)
            {
                if(Player.Balance > Bet)
                {
                    Shoe.Draw(Player._Hand);
                    DealerTurn();
                }
                else
                {
                    Shoe.Draw(Player._Hand);
                    PlayerTurn();
                }   
            }
        }

        public void DealerTurn()
        {

            if (Dealer._Hand.GetValues()[0] > 21)
            {
                DealerBusted = true;
                EndTurn();
            }
            else if (Dealer._Hand.GetValues()[0] < 17)
            {
                Shoe.Draw(Dealer._Hand);
                DealerTurn();
            }
            else
            {
                EndTurn();
            }
        }

        public void EndTurn()
        {
            bool PlayerWins = false;
            int PlayerTotal = Player._Hand.GetValues()[0];
            int DealerTotal = Dealer._Hand.GetValues()[0];

            if (PlayerTotal > DealerTotal) PlayerWins = true;
            if (DealerBusted) PlayerWins = true;
            if (PlayerBusted) PlayerWins = false;


            if (PlayerWins)
            {
                Player.Balance += Bet * 2;
                    if (IsBlackJack)
                    {
                        Player.Balance += Bet;
                    }
            }
            IsBlackJack = false;
            DealerBusted = false;
            PlayerBusted = false;
        }
    }
}
