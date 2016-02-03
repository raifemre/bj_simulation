using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackSimulation
{
    class Program
    {

        


        static void Main(string[] args)
        {

            SimulationEngine engine = new SimulationEngine(8);

            for (int i = 0; i < 30; i++)
            {
                engine.NewTurn(10); Console.WriteLine(engine.Player._Hand.GetValues()[0] + " " + engine.Dealer._Hand.GetValues()[0] + " " + engine.Player.Balance + " " + engine.Bet);
            }
            


            
            














            Console.ReadLine();
        }
    }
}
