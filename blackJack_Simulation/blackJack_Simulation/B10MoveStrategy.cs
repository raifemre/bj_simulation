namespace BlackjackSimulation
{
    class B10MoveStrategy : IPlayerMoveStrategy
    {

        public MoveAction Response(Hand hand, Card dealerUpCard, bool HasSplittedHand)
        {
            MoveAction moveResponse;

            if (!HasSplittedHand && hand.Cards[0] == hand.Cards[1])
            {
                moveResponse = MoveAction.Split;
            }
            else if (hand.GetValues()[0] < 14)
            {

                moveResponse = MoveAction.Hit;
            }
            else
            {
                moveResponse = MoveAction.Stand;
            }
            return moveResponse;
        }
    }
}
