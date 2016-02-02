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

            shu = shoe._Shoe;

            
             Console.WriteLine(shu.Count + " ");
                
            

           
           
            
        }
    }
}
