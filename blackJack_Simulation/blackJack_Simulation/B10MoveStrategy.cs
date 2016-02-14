namespace BlackjackSimulation
{
    class B10MoveStrategy : IPlayerMoveStrategy
    {

        private int[] cardAmounts;

        public B10MoveStrategy(int[] cardAmounts)
        {
            this.cardAmounts = cardAmounts;
        }

        public double probOf(int card)
        {
            return cardAmounts[card] / cardAmounts[0];
        }

        public double winChanceOfHit(int playerTotal, int dealerUpcard, bool Boolean)
        {
            double sum = 0;
            for (int i = 1; i < 11; i++)
            {
                if (playerTotal + i < 22)
                {
                    sum += probOf(i) * winChanceOfHit(playerTotal + i, dealerUpcard, true);
                }
            }
            if (Boolean == true) { sum += winChanceOfStand(playerTotal, dealerUpcard); }
            return sum;
        }

        public double winChanceOfDoubleHit(int pl, int de)
        {
            double sum = 0;
            for (int i = 1; i < 11; i++)
            {
                if (pl + i < 22)
                {
                    sum += probOf(i) * winChanceOfStand(pl + i, de);
                }
            }

            return sum;
        }







        public MoveAction Response(Hand hand, Card dealerUpCard, bool HasSplittedHand)
        {
            MoveAction moveResponse;

           
            return MoveAction.Hit;
        }
    }
}
