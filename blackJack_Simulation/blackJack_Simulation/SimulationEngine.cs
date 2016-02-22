using System;
using System.Collections.Generic;
using System.IO;
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
        private bool log = true;
        public double edge = 0.00;


        public SimulationEngine(int deckAmount, List<Player> externalPlayers)
        {
            currentShoe = new Shoe(deckAmount);
            Players = externalPlayers;
            dealer = new Dealer(new DealerStandOnSoftSeventeen());
            myPlayer = new Player(new BasicStrategy(currentShoe.CardAmounts), new B10BetStrategy(currentShoe.CardAmounts), balance, initialBet);
            Players.Add(myPlayer);
        }

        public void StartNewTurn()
        {
            totalTurns++;
            bool dealerFlag = true;
            Console.WriteLine(new String('*', 60));
            if (log)
                Console.WriteLine(">>Turn: {0:00}\tBalance: {1}\t\tBetAmount: {2}\t\t\t", totalTurns, myPlayer.Balance, myPlayer.BetAmount);

            for (int i = 0; i < Players.Count; i++)
            {

                if (totalTurns > 1)
                    Players[i].BetAmount *= Players[i].BetStrategy.Response(initialBet, wonLastTurn);
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
                currentShoe.Deal(dealer._Hand); //Dealer ilk kart A ikinci kart 10 ise oyunu oynatma
                if (i == 0)
                {
                    currentShoe.CardAmounts[0]--;
                    currentShoe.CardAmounts[(int)dealer._Hand.Cards[0]]--;
                }
                if (i == 1)
                {
                    if (dealer._Hand.Cards[0] == Card.Ace && dealer._Hand.Cards[1].GetCardValue() == 10)
                    {
                        int holeCard = (int)dealer._Hand.Cards[1];
                        currentShoe.CardAmounts[holeCard]--;
                        dealerFlag = false;
                        //TODO: endturn flag EndTurn();
                    }
                }
            }
            if (log) Console.WriteLine("Player: {0:00},{1:00}\tUpcard: {2:00}\t\tBEGIN", myPlayer.Hands[0].Cards[0].GetCardValue(), myPlayer.Hands[0].Cards[1].GetCardValue(), dealer._Hand.Cards[0].GetCardValue());
            //START OF TURNS

            for (int i = 0; i < Players.Count; i++)
            {

                if (Players[i].Hands[0].GetValues()[0] == 21)
                {
                    Players[i].Hands[0].IsBlackjack = true;
                    Players[i].Hands[0].IsCompleted = true;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    if (log) Console.WriteLine("Player: {0:00}\tUpcard: {1:00}\t\tBLACKJACK", Players[i].Hands[0].GetValues()[0], dealer._Hand.Cards[0].GetCardValue());
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                    if (dealerFlag)
                        Turn(Players[i]);
                
            }
            if (dealerFlag)
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
                        if (log)
                            Console.WriteLine("[{0}]Player: {1:00}\tUpcard: {2:00}\t\tBUSTED", i, currentPlayer.Hands[i].GetValues()[0], dealer._Hand.Cards[0].GetCardValue());
                    }
                    else // Hand Value <= 21
                    {
                        //YOK SİLİNECEK
                        //if (currentPlayer.HasSplittedHand() && currentPlayer.Hands[i].Cards.Count == 2 && currentPlayer.Hands[i].GetValues()[0] == 21) //Splitted BJ ? Var mı böyle bir şey emin değilim. 
                        //{
                        //    currentPlayer.Hands[i].IsBlackjack = true;
                        //    currentPlayer.Hands[i].IsCompleted = true;
                        //}

                        MoveAction move = currentPlayer.MoveStrategy.Response(currentPlayer.Hands[i], dealer._Hand.Cards[0], currentPlayer.HasSplittedHand);

                        // 1. response double + kart sayısı 2 den fazla ise = HIT  2. hand splitted + response double = HIT 
                        if ((move == MoveAction.Double && currentPlayer.Hands[i].Cards.Count > 2 && !currentPlayer.HasSplittedHand) || (move == MoveAction.Double && currentPlayer.HasSplittedHand))
                        {
                            move = MoveAction.Hit;
                            // Console.WriteLine("changed");
                        }

                        // A,A split durumunda 2 kartım varsa artık kart alma stand yap
                        if (currentPlayer.HasSplittedHand && currentPlayer.Hands[i].Cards.Count == 2 && currentPlayer.Hands[i].Cards[0] == Card.Ace)
                        {
                            move = MoveAction.Stand;
                        }

                        if (log)
                            Console.WriteLine("[{3}]Player: {0:00}\tUpcard: {1:00}\t\tResponse: {2}", currentPlayer.Hands[i].GetValues()[0], dealer._Hand.Cards[0].GetCardValue(), move, i);

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
                                    if (currentPlayer.Balance >= currentPlayer.BetAmount)
                                    {
                                        currentShoe.Deal(currentPlayer.Hands[i]);
                                        currentShoe.CardAmounts[0]--;
                                        currentShoe.CardAmounts[(int)currentPlayer.LastDealtCard()]--;
                                        currentPlayer.Balance -= currentPlayer.BetAmount;
                                        currentPlayer.Hands[i].IsCompleted = true;
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
                                  
                                    if (!currentPlayer.HasSplittedHand)
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
            Console.BackgroundColor = ConsoleColor.Black;
            if (!currentDealer.HoleCardShowed)
            {
                currentDealer.ShowHoleCard();
                int holeCard = (int)currentDealer._Hand.Cards[1];
                currentShoe.CardAmounts[holeCard]--;
                currentShoe.CardAmounts[0]--;
                if (log) Console.WriteLine("\t\tDnCard: {0:00}\t\tResponse: Opens Down Card", dealer._Hand.Cards[1].GetCardValue());
            }

            if (currentDealer._Hand.GetValues()[0] > 21)
            {
                currentDealer._Hand.IsBusted = true;
                return;
            }

            MoveAction move = dealer.MoveStrategy.Response(currentDealer._Hand);
            if (log) Console.WriteLine("\t\tDealer: {0:00}\t\tResponse: {1}", dealer._Hand.GetValues()[0], move);

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

            if (dealer._Hand.GetValues().Length == 2)
                dealerTotal = dealer._Hand.GetValues()[1];

            bool isTie = false;

            for (int i = 0; i < Players.Count; i++)
            {
                for (int j = 0; j < Players[i].Hands.Count; j++)
                {
                    int playerTotal = Players[i].Hands[j].GetValues()[0];

                    if (playerTotal > 21)
                        Players[i].Hands[j].IsBusted = true;

                        if (Players[i].Hands[j].GetValues().Length == 2)
                        playerTotal = Players[i].Hands[j].GetValues()[1];

                    bool playerWins = false;
                    if (playerTotal > dealerTotal)
                        playerWins = true;
                    if (playerTotal == dealerTotal)
                        isTie = true;
                    if (dealer._Hand.IsBusted)
                        playerWins = true;
                    if (Players[i].Hands[j].IsBusted)
                        playerWins = false;

                    if (playerWins)
                    {

                        Players[i].Balance += Players[i].BetAmount * 2;

                        if (Players[i].Hands[j].IsBlackjack)
                            Players[i].Balance += Players[i].BetAmount / 2;
                        else if (Players[i].Hands[j].IsDoubled)
                            Players[i].Balance += Players[i].BetAmount * 2;

                        wonLastTurn = true;
                        myPlayer.BetAmount = initialBet;

                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        if (log) Console.WriteLine("[{2}]Player: {0:00}\tDealer: {1:00}\t\tWinner: PLAYER\t\t\t", playerTotal, dealerTotal, i);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else if (isTie)
                    {

                        if (!Players[i].Hands[j].IsBlackjack && dealer._Hand.Cards.Count == 2 && dealer._Hand.IsBlackjack)
                        {
                            // berabere ancak dealer ilk iki kartta 21 yaptıysa sen 3 kartla 21 yapıysan tie parası alamazsın !
                        }
                        else if (Players[i].Hands[j].IsBlackjack && dealer._Hand.Cards.Count > 2)  // Playerın BJ yapma + Dealer ın 2 den fazla kartla 21 i bulma  durumu
                        {
                            Players[i].Balance += Players[i].BetAmount * 2.5; //TODO : BURAYI ANLAMADIM ???
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            if (log) Console.WriteLine("[{2}]Player: {0:00}\tDealer: {1:00}\t\tWinner: PLAYER\t\t\t", playerTotal, dealerTotal, i);
                            Console.BackgroundColor = ConsoleColor.Black;
                        }
                        else if (Players[i].Hands[i].IsBusted && dealer._Hand.IsBusted)
                        {
                            if (log) Console.WriteLine("[{2}]Player: {0:00}\tDealer: {1:00}\t\tWinner: DEALER\t\t\t", playerTotal, dealerTotal, i);
                        }
                        else if (Players[i].Hands[i].IsBusted)
                        {
                            // do nothing
                        }
                        else
                        {

                            Players[i].Balance += Players[i].BetAmount;
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            if (log) Console.WriteLine("[{2}]Player: {0:00}\tDealer: {1:00}\t\tWinner: NONE\t\t\t", playerTotal, dealerTotal, i);
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                    }
                    else
                    {
                        wonLastTurn = false;
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        if (log) Console.WriteLine("[{2}]Player: {0:00}\tDealer: {1:00}\t\tWinner: DEALER\t\t\t", playerTotal, dealerTotal, i);
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                }

                //using (StreamWriter writer = new StreamWriter("debug.txt", true))
                //{
                    //writer.WriteLine("{0:00}\t{1:00}", myPlayer.Balance, totalTurns);
                //}

                // Report of each turn
                //Console.WriteLine("P: {0}\tD: {1}\tBalance: {2}", My._Hand.GetValues()[0], Dealer._Hand.GetValues()[0], My.Balance);
                //int[] c = currentShoe.CardAmounts;
                //Console.WriteLine("Total:{0}\tA:{1}\t2:{2}\t3:{3}\t4:{4}\t5:{5}\t6:{6}\t7:{7}\t8:{8}\t9:{9}\t10:{10}\t", c[0], c[1], c[2], c[3], c[4], c[5], c[6], c[7], c[8], c[9], c[10] + c[11] + c[12] + c[13]);



            }

            if (myPlayer.Balance >= myPlayer.BetStrategy.Response(initialBet, wonLastTurn) && currentShoe.CardAmounts[0] > currentShoe.CutCardIndex)
            {
                StartNewTurn();
            }
            else
            {
                edge = (10000 - myPlayer.Balance) / totalTurns; // Edge hesaplama
            }
        }
    }
}
