namespace BlackjackSimulation
{
    class B10BetStrategy : IBetStrategy
    {
        private double[] cardAmounts;

        public B10BetStrategy(double[] cardAmounts)
        {
            this.cardAmounts = cardAmounts;
        }

        public double Response(double initialBet , bool wonLastTurn)
        {
            return 1;
        }
    }
}