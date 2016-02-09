namespace BlackjackSimulation
{
    //TODO: Player'a LostLastHand ekleyip yapılabilir? Taslak olsun diye koydum şuanda.

    class Martingale : IBetStrategy
    {
        public double Response(bool wonLastTurn)
        {
            if (wonLastTurn)
                return 1;
            else
                return 1;// Current Bet Amount'unu *2 yap diye düşündüm, daha güzel yazılabilir?...
        }
    }
}
