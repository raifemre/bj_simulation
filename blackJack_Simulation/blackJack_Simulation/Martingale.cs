namespace BlackjackSimulation
{
    //TODO: Player'a LostLastHand ekleyip yapılabilir? Taslak olsun diye koydum şuanda.

    class Martingale : IBetStrategy
    {
        public double Response()
        {
            return 2.0; // Current Bet Amount'unu *2 yap diye düşündüm, daha güzel yazılabilir?...
        }
    }
}
