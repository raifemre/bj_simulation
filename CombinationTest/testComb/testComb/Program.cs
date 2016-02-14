using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testComb
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] cardAmounts = { 416, 32, 32, 32, 32, 32, 32, 32, 32, 32, 128 };


            double _2_17 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2));

            double _2_18 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _2_19 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _2_20 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * ((cardAmounts[9] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2));

            double _2_21 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[9] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));


            double _3_17 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2));

            double _3_18 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _3_19 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2));

            double _3_20 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2));

            double _3_21 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * ((cardAmounts[9] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));


            double _4_17 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2));

            double _4_18 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2));

            double _4_19 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _4_20 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2));

            double _4_21 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[1] / cardAmounts[0]) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));


            double _5_17 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 2));

            double _5_18 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _5_19 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _5_20 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2));

            double _5_21 =
            (cardAmounts[1] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * ((cardAmounts[8] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));


            double _6_17 =
            (cardAmounts[1] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 2));

            double _6_18 =
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _6_19 =
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _6_20 =
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2));

            double _6_21 =
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[10] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));


            double _7_17 =
            (cardAmounts[10] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 2));

            double _7_18 =
            (cardAmounts[1] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _7_19 =
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _7_20 =
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2));

            double _7_21 =
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * ((cardAmounts[7] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[9] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[10] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));


            double _8_17 =
            (cardAmounts[9] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 2));

            double _8_18 =
            (cardAmounts[10] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _8_19 =
            (cardAmounts[1] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _8_20 =
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2));

            double _8_21 =
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[8] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));


            double _9_17 =
            (cardAmounts[8] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 2));

            double _9_18 =
            (cardAmounts[9] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _9_19 =
            (cardAmounts[10] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _9_20 =
            (cardAmounts[1] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2));

            double _9_21 =
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[10] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * ((cardAmounts[6] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[7] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[9] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));


            double _10_17 =
            (cardAmounts[7] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 2));

            double _10_18 =
            (cardAmounts[8] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _10_19 =
            (cardAmounts[9] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _10_20 =
            (cardAmounts[10] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2));

            double _10_21 =
            (cardAmounts[1] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[9] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[6] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[8] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 2));


            double _1_17 =
            (cardAmounts[6] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 2) / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[1] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[1] - 1) / (cardAmounts[0] - 2));

            double _1_18 =
            (cardAmounts[7] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[2] / (cardAmounts[0] - 2));

            double _1_19 =
            (cardAmounts[8] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * ((cardAmounts[3] - 1) / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[3] / (cardAmounts[0] - 2));

            double _1_20 =
            (cardAmounts[9] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[5] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * (cardAmounts[4] / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[4] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * ((cardAmounts[4] - 1) / (cardAmounts[0] - 2));

            double _1_21 =
            (cardAmounts[10] / cardAmounts[0]) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[8] / (cardAmounts[0] - 1)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[7] / (cardAmounts[0] - 1)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[6] / (cardAmounts[0] - 1)) +
            (cardAmounts[5] / cardAmounts[0]) * ((cardAmounts[5] - 1) / (cardAmounts[0] - 1)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[7] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * ((cardAmounts[2] - 1) / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[2] / cardAmounts[0]) * (cardAmounts[3] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[6] / (cardAmounts[0] - 2)) +
            (cardAmounts[3] / cardAmounts[0]) * (cardAmounts[2] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2)) +
            (cardAmounts[4] / cardAmounts[0]) * (cardAmounts[1] / (cardAmounts[0] - 1)) * (cardAmounts[5] / (cardAmounts[0] - 2));



            Console.WriteLine("1 to 17 : " + _1_17 + " / 1 to 18 : " + _1_18 + " / 1 to 19 : " + _1_19 + " / 1 to 20 : " + _1_20 + " / 1 to 21 : " + _1_21);
            Console.WriteLine("2 to 17 : " + _2_17 + " / 2 to 18 : " + _2_18 + " / 2 to 19 : " + _2_19 + " / 2 to 20 : " + _2_20 + " / 2 to 21 : " + _2_21);
            Console.WriteLine("3 to 17 : " + _3_17 + " / 3 to 18 : " + _3_18 + " / 3 to 19 : " + _3_19 + " / 3 to 20 : " + _3_20 + " / 3 to 21 : " + _3_21);
            Console.WriteLine("4 to 17 : " + _4_17 + " / 4 to 18 : " + _4_18 + " / 4 to 19 : " + _4_19 + " / 4 to 20 : " + _4_20 + " / 4 to 21 : " + _4_21);
            Console.WriteLine("5 to 17 : " + _5_17 + " / 5 to 18 : " + _5_18 + " / 5 to 19 : " + _5_19 + " / 5 to 20 : " + _5_20 + " / 5 to 21 : " + _5_21);
            Console.WriteLine("6 to 17 : " + _6_17 + " / 6 to 18 : " + _6_18 + " / 6 to 19 : " + _6_19 + " / 6 to 20 : " + _6_20 + " / 6 to 21 : " + _6_21);
            Console.WriteLine("7 to 17 : " + _7_17 + " / 7 to 18 : " + _7_18 + " / 7 to 19 : " + _7_19 + " / 7 to 20 : " + _7_20 + " / 7 to 21 : " + _7_21);
            Console.WriteLine("8 to 17 : " + _8_17 + " / 8 to 18 : " + _8_18 + " / 8 to 19 : " + _8_19 + " / 8 to 20 : " + _8_20 + " / 8 to 21 : " + _8_21);
            Console.WriteLine("9 to 17 : " + _9_17 + " / 9 to 18 : " + _9_18 + " / 9 to 19 : " + _9_19 + " / 9 to 20 : " + _9_20 + " / 9 to 21 : " + _9_21);
            Console.WriteLine("10 to 17 : " + _10_17 + " / 10 to 18 : " + _10_18 + " / 10 to 19 : " + _10_19 + " / 10 to 20 : " + _10_20 + " / 10 to 21 : " + _10_21);
            Console.ReadLine();

        }
    }
}
