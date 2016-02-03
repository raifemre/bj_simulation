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

            for (int i = 0; i < 10; i++)
            {
                engine.NewTurn(10); Console.WriteLine(engine.player._Hand.GetValues()[0] + " " + engine.dealer._Hand.GetValues()[0] + " " + engine.player.balance + " " + engine.bet);
            }
            


            
            














            Console.ReadLine();
        }
    }
}
