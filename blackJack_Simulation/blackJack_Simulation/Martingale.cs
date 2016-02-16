namespace BlackjackSimulation
{
    class Martingale : IBetStrategy
    {
        private double[] cardAmounts;

        public Martingale(double[] cardAmounts)
        {
            this.cardAmounts = cardAmounts;
        }

        public double Response(double initialBet, bool wonLastTurn)
        {
            if (wonLastTurn)
                return 1;
            else
                return 2;
        }
    }
}
