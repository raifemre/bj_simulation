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
            Shoe shoe = new Shoe(2);
            Stack<int> cards = shoe.Cards;

            int size = cards.Count;

            for (int i = 0; i < size; i++)
                Console.WriteLine("{0:000}) {1}", i + 1, cards.Pop());

            Console.WriteLine();

            shoe = new Shoe(1);
            cards = shoe.Cards;
            size = cards.Count;

            for (int i = 0; i < size; i++)
                Console.WriteLine("{0:000}) {1}", i + 1, cards.Pop());
        }
    }
}
