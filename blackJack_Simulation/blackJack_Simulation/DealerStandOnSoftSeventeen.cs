namespace BlackjackSimulation
{
    class DealerStandOnSoftSeventeen : IDealerMoveStrategy
    {
        public MoveAction Response(Hand hand)
        {
            if (hand.GetValues().Length == 1) // TODO: no soft hand
            {
                if (hand.GetValues()[0] < 17)
                {
                    return MoveAction.Hit;
                }
                else
                    return MoveAction.Stand; //Mantıksız değil
            }
            else
            {
                //System.Console.WriteLine("Dealer Soft Hand");
                return MoveAction.Hit;
            }
        }
    }
}
