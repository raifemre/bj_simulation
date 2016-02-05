namespace BlackjackSimulation
{
    enum Card
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    static class CardValues
    {
        public static int GetCardValue(this Card card)
        {
            switch (card)
            {
                case Card.Jack:
                case Card.Queen:
                case Card.King:
                    return 10;
                default:
                    return (int)card;
            }
        }
    }
}
