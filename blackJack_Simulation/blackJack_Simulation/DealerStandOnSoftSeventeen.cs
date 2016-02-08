namespace BlackjackSimulation
{
    class DealerStandOnSoftSeventeen : IDealerMoveStrategy
    {
        public MoveAction Response(Hand hand)
        {
            if (hand.GetValues().Length == 2) // TODO: no soft hand
            {
                if (hand.GetValues()[1] < 17)
                {
                    return MoveAction.Hit;
                }
                else
                    return MoveAction.Stand; //Mantıksız değil
            }
            else
            {
                //System.Console.WriteLine("Dealer Soft Hand");
                if (hand.GetValues()[0] < 17)
                {
                    return MoveAction.Hit;
                }
                else
                    return MoveAction.Stand;
            }
        }
    }
}
