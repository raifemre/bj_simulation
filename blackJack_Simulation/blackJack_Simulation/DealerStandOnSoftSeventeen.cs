namespace BlackjackSimulation
{
    class DealerStandOnSoftSeventeen : IDealerMoveStrategy
    {
        public MoveAction Response(Hand hand)
        {
            if (hand.GetValues().Length == 2)
            {
                if (hand.GetValues()[1] < 17)
                {
                    return MoveAction.Hit;
                }
                else
                    return MoveAction.Stand; 
            }
            else
            {                
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
