namespace BlackjackSimulation
{
    class DealerHitOnSoftSeventeen : IDealerMoveStrategy
    {
        public MoveAction Response(Hand hand)
        {
            if (hand.GetValues().Length == 1) // TODO: no soft hand
            {
                if (hand.GetValues()[0] < 18) //Kuralları okumadan yaptım Hit on soft 17 bu demek sanırım?
                {
                    return MoveAction.Hit;
                }
                else
                    return MoveAction.Stand; //Mantıksız değil
            }
            else
            {
                System.Console.WriteLine("Dealer Soft Hand");
                return MoveAction.Hit;
            }
        }
    }
}
