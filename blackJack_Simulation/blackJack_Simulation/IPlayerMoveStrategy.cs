namespace BlackjackSimulation
{
    interface IPlayerMoveStrategy
    {
        MoveAction Response(Hand hand, Card dealerUpCard, bool HasSplittedHand);
    }
}
