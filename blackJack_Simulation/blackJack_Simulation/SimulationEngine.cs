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
            this.shoe = new Shoe(deckAmount);
            this.dealer = new Player(true);
            this.player = new Player(false);
            this.isBlackJack = false;
            this.playerBusted = false;
            this.dealerBusted = false;
        }

        public enum GameAction
        {
            HIT = 1,
            DOUBLE = 2,
            STAND = 3,
            SPLIT = 4
        }

        public Player player { get; private set; }

        public Player dealer { get; private set; }

        public Shoe shoe { get; private set; }

        public int bet { get; private set; }

        public bool isBlackJack { get; private set; }

        public bool playerBusted { get; private set; }

        public bool dealerBusted { get; private set; }


        public void NewTurn(int betson)
        {
            this.bet = betson;
            player.balance -= bet;

            player._Hand.Clear();
            dealer._Hand.Clear();

            shoe.Draw(player._Hand);
            shoe.Draw(dealer._Hand);
            shoe.Draw(player._Hand);
            shoe.Draw(dealer._Hand);

            if(player._Hand.GetValues()[0] == 21)
            {
                isBlackJack = true;
                DealerTurn();
            }

            PlayerTurn();
        }

        public void PlayerTurn()
        {
            if(player._Hand.GetValues()[0] > 21)
            {
                playerBusted = true;
                DealerTurn();
            }

            GameAction response = GameAction.STAND;

            if(response == GameAction.STAND)
            {
                DealerTurn();
            }
            else if (response == GameAction.HIT)
            {
                shoe.Draw(player._Hand);
                PlayerTurn();
            }
            else if (response == GameAction.DOUBLE)
            {
                if(player.balance > bet)
                {
                    shoe.Draw(player._Hand);
                    DealerTurn();
                }
                else
                {
                    shoe.Draw(player._Hand);
                    PlayerTurn();
                }   
            }
        }

        public void DealerTurn()
        {

            if (dealer._Hand.GetValues()[0] > 21)
            {
                dealerBusted = true;
                EndTurn();
            }
            else if (dealer._Hand.GetValues()[0] < 17)
            {
                shoe.Draw(dealer._Hand);
                DealerTurn();
            }
            else
            {
                EndTurn();
            }
        }

        public void EndTurn()
        {
            bool playerWins = false;
            int playerTotal = player._Hand.GetValues()[0];
            int dealerTotal = dealer._Hand.GetValues()[0];

            if (playerTotal > dealerTotal) playerWins = true;
            if (dealerBusted) playerWins = true;
            if (playerBusted) playerWins = false;


            if (playerWins)
            {
                player.balance += bet * 2;
                    if (isBlackJack)
                    {
                        player.balance += bet;
                    }
            }
            isBlackJack = false;
            dealerBusted = false;
            playerBusted = false;
        }
    }
}
