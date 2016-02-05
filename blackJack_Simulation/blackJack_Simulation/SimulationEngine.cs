using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class SimulationEngine
    {
        public Shoe CurrentShoe { get; private set; }
        public Player My { get; private set; }
        public Player Dealer { get; private set; }
        public int CurrentBetAmount { get; private set; }
        public List<Player> Players { get; private set; }
        public int TotalTurns = 0;

        public SimulationEngine(int deckAmount, List<Player> externalPlayers)
        {
            CurrentShoe = new Shoe(deckAmount);
            Strategy.CardAmounts = CurrentShoe.CardAmounts; //Her seferinde argument olarak girmektense, Strategy class'ında da bir referansı tutulsun.
            Players = new List<Player>();
            Dealer = new Player(true, false, 0, 0, 0);
            My = new Player(false, true, 0, 0, 10000);
            Players.Add(Dealer);
            Players.Add(My);
            foreach (Player _player in externalPlayers)
            {
                Players.Add(_player);
            }

        }

        public void StartNewTurn(int betAmount)
        {
            TotalTurns++;

            CurrentBetAmount = betAmount;
            My.Balance -= CurrentBetAmount;

            My._Hand.Clear();
            Dealer._Hand.Clear();


            foreach (Player _player in Players)
            {
                for (int i = 0; i < 2; i++) //TODO: bunu yapmışız! i = 0 da herkese dağıttı ve kartları düştü , i=1 de herkese dağıttı ama dealerın kartını düşmedi ancak totalden düştü. !! dealer 2. kartını açtığında bu kartta düşülmeli !!
                {

                    CurrentShoe.Deal(_player._Hand);
                    CurrentShoe.CardAmounts[0]--;
                    if (i == 1 && !_player.IsDealer)
                        CurrentShoe.CardAmounts[_player.LastCard().GetCardValue()]--;
                    else
                        CurrentShoe.CardAmounts[_player.LastCard().GetCardValue()]--;

                }

            }

            //TODO:[0] [1] -- hard ve soft ayrımı.
            if (My._Hand.GetValues()[0] == 21)
                Turn(Dealer);

            Turn(My);
        }

        public void Turn(Player currentPlayer)
        {
            if (currentPlayer.IsDealer)
            {
                int totalCards = currentPlayer._Hand.AllCards.Count;
                if (totalCards > 2)
                {
                    int currentCard = (int)currentPlayer._Hand.AllCards[totalCards - 1];
                    //TODO: CurrentShoe.CardAmounts[0]--; bunu zaten düşmedik mi başta? başta da düşmeyelim sonuçta kapalı kağıt, hem totalı hem card amountu burda düşelim bence !
                    CurrentShoe.CardAmounts[currentCard]--;
                }

                if (currentPlayer._Hand.GetValues()[0] > 21)
                {
                    currentPlayer._Hand.IsBusted = true;
                    EndTurn();
                }
                else if (currentPlayer._Hand.GetValues()[0] < 17)
                {
                    CurrentShoe.Deal(currentPlayer._Hand);
                    Turn(currentPlayer);
                }
                else
                    EndTurn();
            }

            //Player is a "real" player
            else if (currentPlayer.IsMe)
            {
                if (currentPlayer._Hand.GetValues()[0] > 21)
                {
                    currentPlayer._Hand.IsBusted = true;
                    Turn(Dealer); //bu çok güzel olmadı.
                }

                //Logic implementation...
                MoveAction move = Strategy.MoveStrategyResponse(My._Hand, Dealer._Hand.AllCards[1]); //, new Hand[3] { new Hand(), new Hand(), new Hand() });

                switch (move)
                {
                    case MoveAction.HIT:
                        {
                            CurrentShoe.Deal(currentPlayer._Hand);
                            CurrentShoe.CardAmounts[0]--;
                            CurrentShoe.CardAmounts[currentPlayer.LastCard().GetCardValue()]--;
                            Turn(currentPlayer); //Turn(My);
                            break;
                        }
                    case MoveAction.DOUBLE:
                        {
                            if (currentPlayer.Balance > CurrentBetAmount)
                            {
                                CurrentShoe.Deal(currentPlayer._Hand);
                                CurrentShoe.CardAmounts[0]--;
                                CurrentShoe.CardAmounts[currentPlayer.LastCard().GetCardValue()]--;
                                return;
                            }
                            else
                            {
                                CurrentShoe.Deal(currentPlayer._Hand);
                                CurrentShoe.CardAmounts[0]--;
                                CurrentShoe.CardAmounts[currentPlayer.LastCard().GetCardValue()]--;
                                Turn(currentPlayer); //Turn(My);
                            }
                            break;
                        }
                    case MoveAction.STAND:
                        {
                            Turn(Dealer);
                            break;
                        }
                    case MoveAction.SPLIT:
                        {
                            currentPlayer._Hand.Split();
                            //iyi düşünelim.
                            break;
                        }
                    default:
                        break;
                }
            }
            else
            {
                // other players
            }
        }


        public void EndTurn()
        {
            int PlayerTotal = My._Hand.GetValues()[0];
            int DealerTotal = Dealer._Hand.GetValues()[0];

            bool PlayerWins = false;
            if (PlayerTotal > DealerTotal)
                PlayerWins = true;
            if (Dealer._Hand.IsBusted)
                PlayerWins = true;
            if (My._Hand.IsBusted)
                PlayerWins = false;


            if (PlayerWins)
            {
                My.Balance += CurrentBetAmount * 2;
                //TODO: HasBlackJack ekleyebiliriz Hand class'ına..
                //if (PlayerTotal == 21) //Blackjack
                //    My.Balance += CurrentBetAmount;
            }

            Dealer._Hand.IsBusted = false;
            My._Hand.IsBusted = false;

            // Report of each turn
            //Console.WriteLine("P: {0}\tD: {1}\tBalance: {2}", My._Hand.GetValues()[0], Dealer._Hand.GetValues()[0], My.Balance);
            int[] c = CurrentShoe.CardAmounts;
            //Console.WriteLine("Total:{0}\tA:{1}\t2:{2}\t3:{3}\t4:{4}\t5:{5}\t6:{6}\t7:{7}\t8:{8}\t9:{9}\t10:{10}\t", c[0], c[1], c[2], c[3], c[4], c[5], c[6], c[7], c[8], c[9], c[10] + c[11] + c[12] + c[13]);

            int betStrategyResponse = Strategy.BetStrategyResponse();

            if (My.Balance > betStrategyResponse && CurrentShoe.CardAmounts[0] > CurrentShoe.CutCardIndex)
            {
                StartNewTurn(betStrategyResponse);
            }
        }
    }
}
