namespace BlackjackSimulation
{
    interface IBetStrategy
    {
        double Response(double initialBet ,bool wonLastHand, int[] cardAmounts);
    }
}
