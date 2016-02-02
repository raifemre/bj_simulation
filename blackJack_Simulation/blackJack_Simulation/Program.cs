using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoe shoe = new Shoe(8);

            Stack<int> shu = new Stack<int>();
            List<int> so = new List<int>();

            shu = shoe._Shoe;

            for (int i = 0; i < 416; i++)
            {
                so.Add(shu.Pop());
                
            }

            so.Sort();

            for (int i = 0; i < 416; i++)
            {
                Console.WriteLine(i + " " + so[i]);

            }







        }
    }
}
