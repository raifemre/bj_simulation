using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class SimulationEngine
    {
        private Shoe currentShoe;
        public Player myPlayer;
        private Dealer dealer;
        private List<Player> Players;
        private int totalTurns = 0;
        private bool wonLastTurn = false;
        private double balance = 10000.0;
        private double initialBet = 100.0;

        public SimulationEngine(int deckAmount, List<Player> externalPlayers)
        {
            currentShoe = new Shoe(deckAmount);
            Players = externalPlayers;
            dealer = new Dealer(new DealerStandOnSoftSeventeen());
            myPlayer = new Player(new BasicStrategy(), new Martingale(), balance, initialBet);
            Players.Add(myPlayer);
        }

        public void StartNewTurn()
        {
            totalTurns++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(">>Turn: {0:00}\tBalance: {1}", totalTurns, myPlayer.Balance);
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < Players.Count; i++)
            {
                if (totalTurns > 1)
                    Players[i].BetAmount *= Players[i].BetStrategy.Response(wonLastTurn);
                Players[i].Balance -= Players[i].BetAmount;
                Players[i].ClearHands();
            }

            dealer.ClearHand();

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < Players.Count; j++)
                {
                    currentShoe.Deal(Players[j].Hands[0]);
                    currentShoe.CardAmounts[0]--;
                    currentShoe.CardAmounts[(int)Players[j].LastDealtCard()]--;
                }
                currentShoe.Deal(dealer._Hand); // TODO: Dealer ilk kart A ikinci kart 10 ise oyunu oynatma
                if (i == 0) //TODO: i == 1 (dealer's closed card) durumunu Turn(dealer) içerisinde yapıyoruz. - değiştirilebilir? - totalı da sonradan düşüyorum - konuşalım bunu.
                {
                    currentShoe.CardAmounts[0]--;
                    currentShoe.CardAmounts[(int)dealer._Hand.Cards[0]]--;
                }
            }

            //START OF TURNS
            for (int i = 0; i < Players.Count; i++)
            {
                if (Players[i].Hands[0].GetValues()[0] == 21)
                {
                    Players[i].Hands[0].IsBlackjack = true;
                    Players[i].Hands[0].IsCompleted = true;
                    //continue;
                }
                else
                    Turn(Players[i]);
            }
            Turn(dealer);
            EndTurn();
            //END OF TURNS
        }

        //TODO: Soft Total'lar için düzenleme gerekli
        public void Turn(Player currentPlayer)
        {
            for (int i = 0; i < currentPlayer.Hands.Count; i++)
            {
                if (!currentPlayer.Hands[i].IsCompleted)
                {
                    if (currentPlayer.Hands[i].GetValues()[0] > 21 && !currentPlayer.Hands[i].IsBusted)
                    {
                        currentPlayer.Hands[i].IsBusted = true;
                        currentPlayer.Hands[i].IsCompleted = true;
                    }
                    //if (currentPlayer.Hands[i].GetValues()[0] > 21 && !currentPlayer.Hands[i].IsBusted)   // TODO: şurada bir problem var mesela hand splitted ilk el patladı ikinci ele giriyor ama total card olarak ilk elinkini alıyor ! continue ile alakalı bir prblem olabilirmi. continue olayını net bilmediğimden ellemedim. continue nereden çıkarıyor burada tam olarak ?
                    //{
                    //    currentPlayer.Hands[i].IsBusted = true;

                    //    if (!currentPlayer.HasSplittedHand()) // split yapmadı ve patladıysa sıra bir sonraki oyuncuda/dealerda
                    //    {
                    //        currentPlayer.Hands[i].IsCompleted = true;
                    //        continue;
                    //    }
                    //    else  // split yapmış ve ilk eli patladıysa devam et ikinci ele bak. Eğer ikinci el patladı ise sıra bir sonraki oyuncuda/dealerda
                    //    {
                    //        if (i == 1)
                    //        {
                    //            currentPlayer.Hands[i].IsBusted = true;
                    //            currentPlayer.Hands[i].IsCompleted = true;
                    //            continue;
                    //        }
                    //    }
                    //}
                    else // Hand Value <= 21
                    {
                        if (currentPlayer.HasSplittedHand() && currentPlayer.Hands[i].Cards.Count == 2 && currentPlayer.Hands[i].GetValues()[0] == 21) //Splitted BJ ? Var mı böyle bir şey emin değilim.
                        {
                            currentPlayer.Hands[i].IsBlackjack = true;
                            currentPlayer.Hands[i].IsCompleted = true;
                            //continue;
                        }
                        
                        MoveAction move = currentPlayer.MoveStrategy.Response(currentPlayer.Hands[i], dealer._Hand.Cards[0], currentPlayer.HasSplittedHand());
                        //Console.WriteLine("[{3}]Player: {0:00}\tUpcard: {1:00}\t\tResponse: {2}", currentPlayer.Hands[i].GetValues()[0], dealer._Hand.Cards[0].GetCardValue(),move,i);
                        //if (currentPlayer.HasSplittedHand() && move == MoveAction.Split)
                        //{
                        //    //  move = ??? , eğer splitted ise bidaha split yapmaması için move değiştirmek gerek. movestrageyt extra parameter isSplitted bool almalı diyorum onun için.
                        //    // Response içerisinde hallederiz artık..
                        //}

                        switch (move)
                        {
                            case MoveAction.Hit:
                                {
                                    currentShoe.Deal(currentPlayer.Hands[i]);
                                    currentShoe.CardAmounts[0]--;
                                    currentShoe.CardAmounts[(int)currentPlayer.LastDealtCard()]--;
                                    Turn(currentPlayer);
                                    break;
                                }
                            case MoveAction.Double:
                                {
                                    currentPlayer.Hands[i].IsDoubled = true;
                                    //Splittedsa durumuna MoveStrategy.Response() içerisinde bakacağımız için, eğer splittedsa zaten Double dönmeyecektir.
                                    if (currentPlayer.Balance >= currentPlayer.BetAmount)
                                    {                                        
                                        currentShoe.Deal(currentPlayer.Hands[i]);
                                        currentShoe.CardAmounts[0]--;
                                        currentShoe.CardAmounts[(int)currentPlayer.LastDealtCard()]--;
                                        currentPlayer.Balance -= currentPlayer.BetAmount; // burada düşüyor sanırım balance'dan..
                                        currentPlayer.Hands[i].IsCompleted = true;
                                        //return; - bu sıkıntılı bir hareket, akış devam etmeli gibi.
                                    }
                                    else
                                    {
                                        currentShoe.Deal(currentPlayer.Hands[i]);
                                        currentShoe.CardAmounts[0]--;
                                        currentShoe.CardAmounts[(int)currentPlayer.LastDealtCard()]--;
                                        Turn(currentPlayer);
                                    }
                                    break;
                                }
                            case MoveAction.Stand:
                                {
                                    currentPlayer.Hands[i].IsCompleted = true;
                                    break;
                                }
                            case MoveAction.Split: //TODO : split üstüne split kontrolu
                                {
                                    
                                    if (!currentPlayer.HasSplittedHand())
                                    {
                                        currentPlayer.SplitHand();
                                        currentPlayer.Balance -= currentPlayer.BetAmount;
                                        Turn(currentPlayer);
                                        
                                    }
                                    break;
                                }
                            default:
                                break;
                        }
                    }
                }
            }
        }

        public void Turn(Dealer currentDealer)
        {
            if (!currentDealer.ClosedCardTurned)
            {
                currentDealer.TurnClosedCard();
                int closedCard = (int)currentDealer._Hand.Cards[1];
                currentShoe.CardAmounts[closedCard]--;
                currentShoe.CardAmounts[0]--; //TODO: Total'ı da burada düşüyorum - konuşalım bunu.
            }

            if (currentDealer._Hand.GetValues()[0] > 21)
            {
                currentDealer._Hand.IsBusted = true;
                return;
            }

            MoveAction move = dealer.MoveStrategy.Response(currentDealer._Hand);

            switch (move)
            {
                case MoveAction.Hit:
                    {
                        currentShoe.Deal(currentDealer._Hand);
                        currentShoe.CardAmounts[0]--;
                        currentShoe.CardAmounts[(int)currentDealer.LastDealtCard()]--;
                        Turn(dealer);
                        break;
                    }
                case MoveAction.Stand:
                    break;
                default:
                    break;
            }
        }


       
        public void EndTurn()
        {
            int dealerTotal = dealer._Hand.GetValues()[0];

            for (int i = 0; i < Players.Count; i++)
            {
                for (int j = 0; j < Players[i].Hands.Count; j++)
                {
                    int playerTotal = Players[i].Hands[j].GetValues()[0];

                    bool playerWins = false;
                    if (playerTotal > dealerTotal)
                        playerWins = true;
                    if (dealer._Hand.IsBusted)
                        playerWins = true;
                    if (Players[i].Hands[j].IsBusted)
                        playerWins = false;

                    //TODO : tie parası gelsin
                    if (playerWins)
                    {
                        Players[i].Balance += Players[i].BetAmount * 2;
                        if (Players[i].Hands[j].IsBlackjack)
                        {
                            Players[i].Balance += Players[i].BetAmount;
                        }
                        if (Players[i].Hands[j].IsDoubled)
                        {
                            Players[i].Balance += Players[i].BetAmount*2;
                        }
                        wonLastTurn = true;
                        myPlayer.BetAmount = initialBet;
                    }
                    else
                    {
                        wonLastTurn = false;
                    }
                }


                // Report of each turn
                //Console.WriteLine("P: {0}\tD: {1}\tBalance: {2}", My._Hand.GetValues()[0], Dealer._Hand.GetValues()[0], My.Balance);
                //int[] c = currentShoe.CardAmounts;
                //Console.WriteLine("Total:{0}\tA:{1}\t2:{2}\t3:{3}\t4:{4}\t5:{5}\t6:{6}\t7:{7}\t8:{8}\t9:{9}\t10:{10}\t", c[0], c[1], c[2], c[3], c[4], c[5], c[6], c[7], c[8], c[9], c[10] + c[11] + c[12] + c[13]);

                if (myPlayer.Balance >= myPlayer.BetStrategy.Response(wonLastTurn) && currentShoe.CardAmounts[0] > currentShoe.CutCardIndex)
                {
                    StartNewTurn();
                }
                else
                {
                    Console.WriteLine(">>Balance: {0}", myPlayer.Balance);
                }
                    
            }
        }
    }
}
