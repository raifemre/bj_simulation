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


        public SimulationEngine(int deckAmount)
        {
            CurrentShoe = new Shoe(deckAmount);
            Dealer = new Player(true, 0);
            My = new Player(false, 10000);
            My._Hand.IsBusted = false;
            Dealer._Hand.IsBusted = false;
        }

        public void NewTurn(int betAmount)
        {
            CurrentBetAmount = betAmount;
            My.Balance -= CurrentBetAmount;

            My._Hand.Clear();
            Dealer._Hand.Clear();

            //düş 
            CurrentShoe.Deal(My._Hand);
            CurrentShoe.Deal(Dealer._Hand);
            //düş - Split ve Double Stratejisi burada belirlenmeli.
            CurrentShoe.Deal(My._Hand);
            //düşme
            CurrentShoe.Deal(Dealer._Hand);

            //TODO:[0] [1]
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
                    CurrentShoe.CardAmounts[0]--;
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
            else
            {
                if (currentPlayer._Hand.GetValues()[0] > 21)
                {
                    currentPlayer._Hand.IsBusted = true;
                    Turn(Dealer); //bu çok güzel olmadı.
                }

                //Logic implementation...
                MoveAction move = MoveAction.STAND;

                switch (move)
                {
                    case MoveAction.HIT:
                        {
                            CurrentShoe.Deal(currentPlayer._Hand);
                            Turn(currentPlayer); //Turn(My);
                            break;
                        }
                    case MoveAction.DOUBLE:
                        {
                            if (currentPlayer.Balance > CurrentBetAmount)
                            {
                                CurrentShoe.Deal(currentPlayer._Hand);
                                return;
                            }
                            else
                            {
                                CurrentShoe.Deal(currentPlayer._Hand);
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
                        break;
                    default:
                        break;
                }
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
                if (PlayerTotal == 21) //Blackjack
                    My.Balance += CurrentBetAmount;
            }

            Dealer._Hand.IsBusted = false;
            My._Hand.IsBusted = false;
        }
    }
}



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace BlackjackSimulation
//{
//    class SimulationEngine
//    {
//        public Shoe CurrentShoe { get; private set; }
//        public Player Me { get; private set; }
//        public Player Dealer { get; private set; }
//        public int CurrentBetAmount { get; private set; }
//        public bool IsBlackJack { get; private set; } 
//        public bool IsPlayerBusted { get; private set; }
//        public bool IsDealerBusted { get; private set; }        

//        public SimulationEngine(int deckAmount)
//        {
//            CurrentShoe = new Shoe(deckAmount);
//            Dealer = new Player(true,0);
//            Me = new Player(false,10000);
//            IsBlackJack = false;
//            IsPlayerBusted = false;
//            IsDealerBusted = false;
//        }

//        public void NewTurn(int bet)
//        {
//            CurrentBetAmount = bet;
//            Me.Balance -= CurrentBetAmount;

//            Me._Hand.Clear();
//            Dealer._Hand.Clear();

//            //düş 
//            CurrentShoe.Deal(Me._Hand);
//            CurrentShoe.Deal(Dealer._Hand);
//            //düş - Split ve Double Stratejisi burada belirlenmeli.
//            CurrentShoe.Deal(Me._Hand);
//            //düşme
//            CurrentShoe.Deal(Dealer._Hand);

//            //TODO:[0] [1]
//            if(Me._Hand.GetValues()[0] == 21)
//            {
//                IsBlackJack = true;
//                DealerTurn();
//            }

//            PlayerTurn();
//        }

//        //TODO: Turn method'unu PlayerTurn veya DealerTurn yapmak yerine Turn(Dealer);, Turn(Player); şeklinde çağırabileceğimiz tek bir metoda indirgeyebiliriz !
//        //if Player, if Dealer.. 
//        //Birden fazla bizim yönetebileceğimiz Player'a sahip olup değişik testler de yapabiliriz ileride ???
//        public void PlayerTurn()
//        {
//            if(Me._Hand.GetValues()[0] > 21)
//            {
//                IsPlayerBusted = true;
//                //void'e return şeeklii - veya Tersine çevirebiliriz bu kısmı < 21'se aşağıdakileri yapar..
//                //Obsolote: DealerTurn();
//                return;                
//            }

//            //17 ThinkAction...
//            MoveAction move = MoveAction.STAND;

//            if(move == MoveAction.STAND)
//                DealerTurn();
//            else if (move == MoveAction.HIT)
//            {
//                CurrentShoe.Deal(Me._Hand);
//                PlayerTurn();
//            }
//            else if (move == MoveAction.DOUBLE)
//            {
//                if(Me.Balance > CurrentBetAmount)
//                {
//                    CurrentShoe.Deal(Me._Hand);
//                    DealerTurn();
//                }
//                else
//                {
//                    CurrentShoe.Deal(Me._Hand);
//                    PlayerTurn();
//                }   
//            }
//        }

//        public void DealerTurn()
//        {            
//            //if Dealer.Hand.Count > 2 
//            //TODO: Array'den düş CurrentShoe.CardAmounts // fena değil gibi?
//            int totalCards = Dealer._Hand.AllCards.Count;
//            if (totalCards > 2)
//            {
//                int currentCard = (int)Dealer._Hand.AllCards[totalCards - 1];
//                CurrentShoe.CardAmounts[0]--;
//                CurrentShoe.CardAmounts[currentCard]--;
//            }

//            if (Dealer._Hand.GetValues()[0] > 21)
//            {
//                IsDealerBusted = true;
//                EndTurn();
//            }
//            else if (Dealer._Hand.GetValues()[0] < 17)
//            {
//                CurrentShoe.Deal(Dealer._Hand);
//                DealerTurn();
//            }
//            else
//                EndTurn();
//        }

//        public void EndTurn()
//        {
//            int PlayerTotal = Me._Hand.GetValues()[0];
//            int DealerTotal = Dealer._Hand.GetValues()[0];

//            bool PlayerWins = false;
//            if (PlayerTotal > DealerTotal)
//                PlayerWins = true;
//            if (IsDealerBusted) 
//                PlayerWins = true;
//            if (IsPlayerBusted) 
//                PlayerWins = false;


//            if (PlayerWins)
//            {
//                Me.Balance += CurrentBetAmount * 2;
//                if (IsBlackJack)
//                    Me.Balance += CurrentBetAmount;
//            }

//            IsBlackJack = false;
//            IsDealerBusted = false;
//            IsPlayerBusted = false;
//        }
//    }
//}
