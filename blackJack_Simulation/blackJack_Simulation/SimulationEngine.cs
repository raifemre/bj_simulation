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
            Players.Add(My);
            foreach (Player _player in externalPlayers)
            {
                Players.Add(_player);
            }
            Players.Add(Dealer); // dealer added last

        }

        public void StartNewTurn(int betAmount)
        {
            TotalTurns++;
            Console.WriteLine("Turn: "+ TotalTurns + " Balance: " + My.Balance);
            
           CurrentBetAmount = betAmount;
            My.Balance -= CurrentBetAmount;

            if (My.IsSplitted())
            {
                My.Hands.Remove(My.Hands[1]);
            }
            My._Hand.Clear();
            Dealer._Hand.Clear();


            foreach (Player _player in Players)
            {
                for (int i = 0; i < 2; i++) //TODO: bunu yapmışız! i = 0 da herkese dağıttı ve kartları düştü , i=1 de herkese dağıttı ama dealerın kartını düşmedi ancak totalden düştü. !! dealer 2. kartını açtığında bu kartta düşülmeli !!
                {

                    CurrentShoe.Deal(_player._Hand);
                    CurrentShoe.CardAmounts[0]--;
                    if (i == 1 && !_player.IsDealer)
                        CurrentShoe.CardAmounts[_player.LastCard(_player.Hands[0]).GetCardValue()]--;
                    //else
                       // CurrentShoe.CardAmounts[_player.LastCard().GetCardValue()]--;

                }

            }

            //TODO:[0] [1] -- hard ve soft ayrımı.
            if (My._Hand.GetValues()[0] == 21)
            {
                Turn(Dealer);
            }
            else
            {
                Turn(My);
            }



            
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
                else
                {
                    CurrentShoe.CardAmounts[currentPlayer.LastCard(currentPlayer.Hands[0]).GetCardValue()]--;
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
                
                for (int i = 0; i < currentPlayer.Hands.Count; i++) // eğer split ise ikisi içinde işlem yap
                {
                    if (!currentPlayer.Hands[i].IsDone)  // isDone şimdilik koydum. bu elle işim bitti veya bitmedi demek için
                    {
                        if (currentPlayer.Hands[i].GetValues()[0] > 21 && !currentPlayer.Hands[i].IsBusted)
                        {
                            currentPlayer.Hands[i].IsBusted = true;
                            if (!currentPlayer.IsSplitted()) // split yapmadı ve patladıysa sıra dealerda
                            {
                                currentPlayer.Hands[i].IsDone = true;
                                Turn(Dealer);
                            }
                            else  // split yapmış ve ilk eli patladıysa devam et ikinci ele bak. Eğer ikinci el patladı ise sıra dealerda.
                            {
                                if (i == 1)
                                {
                                    currentPlayer.Hands[i].IsDone = true;
                                    Turn(Dealer);
                                }
                                    
                            }
                            //bu çok güzel olmadı. else koydum şimdi hemen 2 satır alta, sorun yok.
                        }
                        else {

                            //Logic implementation...
                            MoveAction move = Strategy.MoveStrategyResponse(My.Hands[i], Dealer._Hand.AllCards[1]); //, new Hand[3] { new Hand(), new Hand(), new Hand() });

                            if (currentPlayer.IsSplitted() && move == MoveAction.SPLIT)
                            {
                                //  move = ??? , eğer splitted ise bidaha split yapmaması için move değiştirmek gerek. movestrageyt extra parameter isSplitted bool almalı diyorum onun için.
                            }

                            switch (move)
                            {
                                case MoveAction.HIT:
                                    {
                                        CurrentShoe.Deal(currentPlayer.Hands[i]);
                                        CurrentShoe.CardAmounts[0]--;
                                        CurrentShoe.CardAmounts[currentPlayer.LastCard(currentPlayer.Hands[i]).GetCardValue()]--;
                                        Turn(currentPlayer); //Turn(My);
                                        break;
                                    }
                                case MoveAction.DOUBLE:
                                    {
                                        if (currentPlayer.Balance > CurrentBetAmount)
                                        {
                                            CurrentShoe.Deal(currentPlayer.Hands[i]);
                                            CurrentShoe.CardAmounts[0]--;
                                            CurrentShoe.CardAmounts[currentPlayer.LastCard(currentPlayer.Hands[i]).GetCardValue()]--;
                                            return;
                                        }
                                        else
                                        {
                                            CurrentShoe.Deal(currentPlayer.Hands[i]);
                                            CurrentShoe.CardAmounts[0]--;
                                            CurrentShoe.CardAmounts[currentPlayer.LastCard(currentPlayer.Hands[i]).GetCardValue()]--;
                                            Turn(currentPlayer); //Turn(My);
                                        }
                                        break;
                                    }
                                case MoveAction.STAND:
                                    {
                                        
                                        if (!currentPlayer.IsSplitted())
                                        {
                                            currentPlayer.Hands[i].IsDone = true;
                                            Turn(Dealer);
                                        }
                                        else
                                        {
                                            if (i == 1)
                                            {
                                                currentPlayer.Hands[i].IsDone = true;
                                                Turn(Dealer);
                                            }
                                        }
                                            
                                        break;
                                    }
                                case MoveAction.SPLIT:
                                    {
                                        Console.WriteLine("SPLIT");
                                        if (!currentPlayer.IsSplitted())
                                        {
                                            currentPlayer.Split();
                                            Turn(currentPlayer);
                                        }
                                        else
                                        {
                                            Turn(Dealer);
                                        }
                                                    
                                        // iyi düşünelim. düşünüldü. tamam.
                                        break;
                                    }
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            else
            {
                // other players
            }
        }


        public void EndTurn()
        {
            for (int i = 0; i < My.Hands.Count; i++)
            {

                int PlayerTotal = My.Hands[i].GetValues()[0];
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
                My.Hands[i].IsBusted = false;
                My.Hands[i].IsDone = false;
                My.Hands[i].IsDone = false;
            }
           

            // Report of each turn
            //Console.WriteLine("P: {0}\tD: {1}\tBalance: {2}", My._Hand.GetValues()[0], Dealer._Hand.GetValues()[0], My.Balance);
            int[] c = CurrentShoe.CardAmounts;
            //Console.WriteLine("Total:{0}\tA:{1}\t2:{2}\t3:{3}\t4:{4}\t5:{5}\t6:{6}\t7:{7}\t8:{8}\t9:{9}\t10:{10}\t", c[0], c[1], c[2], c[3], c[4], c[5], c[6], c[7], c[8], c[9], c[10] + c[11] + c[12] + c[13]);

            int betStrategyResponse = Strategy.BetStrategyResponse();
           
            if (My.Balance > betStrategyResponse && CurrentShoe.CardAmounts[0] > CurrentShoe.CutCardIndex)
            {
                
                StartNewTurn(betStrategyResponse);
            }
            else
            {
                
            }
        }
    }
}
