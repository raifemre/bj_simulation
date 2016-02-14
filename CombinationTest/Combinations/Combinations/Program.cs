using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        public static void Main(string[] args)
        {



            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };





            //dortlu_comb(numbers, upcard, target);



            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream(@"C:\Users\raifemre\Desktop\Combinations.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Redirect.txt for writing");
                Console.WriteLine(e.Message);
                return;
            }
            Console.SetOut(writer);

            for (int j = 2; j < 12; j++)
            {
                Console.WriteLine();

                for (int i = 17; i < 22; i++)
                {
                    Console.WriteLine("double _{0}_{1} = ", j, i);
                    tekli_comb(numbers, j, i);
                    ikili_comb(numbers, j, i);
                    uclu_comb(numbers, j, i);
                    Console.WriteLine();

                }
            }


            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();

            Console.WriteLine();
            Console.ReadLine();
        }

        private static void tekli_comb(List<int> numbers, int upcard, int target)
        {

            if ((target - upcard) < 12)
                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) + ", (target - upcard));
            //Console.WriteLine(target - upcard);

        }




        private static void ikili_comb(List<int> numbers, int upcard, int target)
        {

            for (int i = 1; i < 11; i++)
            {
                if (upcard + i < 17)
                    if (!(i == 1 && upcard + 11 > 16))
                        if (((target - upcard - i) < 12 && (target - upcard - i) > 0) || ((i == 1) && (target - upcard - 11) < 12))



                            if (i == (target - upcard - i))
                            {
                                if ((target - upcard - i) > 10)
                                {
                                    Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * ((cardAmounts[{1}]-1) / (cardAmounts[0]-1)) + ", i, (target - upcard - i - 10));
                                }
                                else
                                {
                                    Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * ((cardAmounts[{1}]-1) / (cardAmounts[0]-1)) + ", i, (target - upcard - i));
                                }

                            }
                            else
                            {

                                if ((target - upcard - i) > 10)
                                {
                                    Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) + ", i, (target - upcard - i - 10));
                                }
                                else
                                {
                                    Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) + ", i, (target - upcard - i));
                                }

                            }

            }

        }
        private static void uclu_comb(List<int> numbers, int upcard, int target)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (upcard + i < 17 && upcard + i + j < 17)
                        if (!(i == 1 && upcard + 11 > 16))
                            if (!(i == 1 && upcard + 11 + j > 16))
                                if (!(j == 1 && (upcard + i + 11 > 16 && (upcard + i) < 11)))
                                    if (((target - upcard - i - j) < 12 && (target - upcard - i - j) > 0) || ((i == 1) && (target - upcard - 11 - j) < 12))


                                        if (i == j && i == (target - upcard - i - j))
                                        {
                                            if ((target - upcard - i - j) > 10)
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * ((cardAmounts[{1}]-1) / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-2) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j - 10));
                                            }
                                            else
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * ((cardAmounts[{1}]-1) / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-2) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                            }

                                            //    Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * ((cardAmounts[{1}]-1) / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-2) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                        }
                                        else if (i == (target - upcard - i - j))
                                        {
                                            if ((target - upcard - i - j) > 10)
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-1) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j - 10));
                                            }
                                            else
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-1) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                            }

                                            //    Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-1) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                        }
                                        else if (j == (target - upcard - i - j))
                                        {
                                            if ((target - upcard - i - j) > 10)
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-1) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j - 10));
                                            }
                                            else
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-1) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                            }

                                            //   Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * ((cardAmounts[{2}]-1) / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                        }
                                        else if (i == j)
                                        {
                                            if ((target - upcard - i - j) > 10)
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * ((cardAmounts[{1}]-1) / (cardAmounts[0]-1)) * (cardAmounts[{2}] / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j - 10));
                                            }
                                            else
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * ((cardAmounts[{1}]-1) / (cardAmounts[0]-1)) * (cardAmounts[{2}] / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                            }

                                            //    Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * ((cardAmounts[{1}]-1) / (cardAmounts[0]-1)) * (cardAmounts[{2}] / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                        }
                                        else
                                        {
                                            if ((target - upcard - i - j) > 10)
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * (cardAmounts[{2}] / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j - 10));
                                            }
                                            else
                                            {
                                                Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * (cardAmounts[{2}] / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                            }

                                            //    Console.WriteLine("(cardAmounts[{0}] / cardAmounts[0]) * (cardAmounts[{1}] / (cardAmounts[0]-1)) * (cardAmounts[{2}] / (cardAmounts[0]-2)) + ", i, j, (target - upcard - i - j));
                                        }


                }

            }

        }

        private static void dortlu_comb(List<int> numbers, int upcard, int target)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    for (int k = 1; k < 11; k++)
                    {
                        if (upcard + i < 17 && upcard + i + j < 17 && upcard + i + j + k < 17)
                            if (!(i == 1 && upcard + 11 > 16))

                                Console.WriteLine(i + " " + j + " " + k + " " + (target - upcard - i - j - k));
                    }

                }

            }

        }
    }


}