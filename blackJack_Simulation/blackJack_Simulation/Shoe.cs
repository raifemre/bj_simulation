using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace BlackJackSimulation
{
    class Shoe
    {
        public int _deckAmount;
        public Stack<int> _Shoe;
        public List<int> _ShoeList;

        public Shoe(int deckAmount)
        {
            this._deckAmount = deckAmount;
            _Shoe = new Stack<int>();
            _ShoeList = new List<int>();
            GenerateShoe();
            Shuffle();
        }



        public void GenerateShoe()
        {

            for (int i = 1; i < 10; i++)
            {
                for (int j = 0; j < 4 * _deckAmount; j++)
                {
                    _ShoeList.Add(i);
                }
            }
            for (int i = 0; i < 4 * 4 * _deckAmount; i++)
            {
                _ShoeList.Add(10);

            }


        }



        public void Shuffle()
        {
            int size = _ShoeList.Count;
            Stack<int> temp = new Stack<int>();
            for (int i = 0; i < size; i++)
            {
                int r = NextInt(0, _ShoeList.Count - 1);
                temp.Push(_ShoeList[r]);
                _ShoeList.RemoveAt(r);

            }

            _Shoe = temp;

        }


        private static int NextInt(int min, int max)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buffer = new byte[4];

            rng.GetBytes(buffer);
            int result = BitConverter.ToInt32(buffer, 0);

            return new Random(result).Next(min, max);
        }

    }
}
