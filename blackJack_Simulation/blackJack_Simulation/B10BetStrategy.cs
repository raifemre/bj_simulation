namespace BlackjackSimulation
{
    class B10BetStrategy : IBetStrategy
    {
        private int[] cardAmounts;

        public B10BetStrategy(int[] cardAmounts)
        {
            this.cardAmounts = cardAmounts;
        }

        public double Response(double initialBet , bool wonLastTurn)
        {
            return 1;
        }
    }
}