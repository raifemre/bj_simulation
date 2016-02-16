using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationTests2
{
    class Combination
    {
        public double Num;
        public IEnumerable<Combination> Combinations;
    }

    class Probabilities
    {
        public static int MaxCombinationNumber;
        public static double[] cardAmounts;

        public static IEnumerable<Combination> GetCombinationTrees(double num, double max)
        {
            IEnumerable<Combination> combination = Enumerable.Range(1, (int)num)
                             .Where(n => n <= max)
                             .Where(n => n <= 11)
                             .Select(n =>
                                 new Combination
                                 {
                                     Num = n,
                                     Combinations = GetCombinationTrees(num - n, n)
                                 });
            return combination;
        }

        public static IEnumerable<IEnumerable<double>> BuildCombinations(IEnumerable<Combination> combinations)
        {
            if (combinations.Count() == 0)
            {
                return new[] { new double[0] };
            }
            else
            {
                return combinations.SelectMany(c => BuildCombinations(c.Combinations).Select(l => new[] { c.Num }.Concat(l)));
            }
        }

        public static IEnumerable<IEnumerable<double>> GetCombinations(double num)
        {
            var combinationsList = GetCombinationTrees(num, num);

            return BuildCombinations(combinationsList);
        }

        public static List<List<double>> GetAllCombinations(double upCard, double goal)
        {
            double toplam = upCard;
            double num = goal - upCard;
            var tempRow = new List<double>();
            var list = new List<List<double>>();

            var allCombinations = GetCombinations(num);

            foreach (var c in allCombinations)
            {
                tempRow = c.ToList<double>();
                if (tempRow.Count <= MaxCombinationNumber)
                    list.Add(c.ToList<double>());
            }

            return list;
        }

        public static double GetProbability(double upCard, double goal)
        {
            cardAmounts = new double[14] { 416, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32 };
            List<List<double>> liste;

            if (upCard == 1 || upCard == 11)
            {
                liste = GetAllCombinations(1, goal);
                liste.AddRange(GetAllCombinations(11, goal));
            }
            else
                liste = GetAllCombinations(upCard, goal);


            double probability = 0;

            for (int i = 0; i < liste.Count; i++)
            {
                int cardAmountsTekrar = 0;
                int lastCardTekrar = 0;
                int lastCard = 0;
                double probabilityRow = 1;
                

                Console.Write("(");
                foreach (int currentCard in liste[i])
                {
                    if (currentCard == 1 || currentCard == 11)
                    {
                        double cardAmounts1 = cardAmounts[1];

                        if (currentCard == lastCard)
                        {
                            cardAmounts1 -= 1;
                            lastCardTekrar++;

                            if (cardAmountsTekrar > 0)
                                Console.Write("( (cardAmounts[1] - {0}) / (cardAmounts[0] - {1}) ) * ", lastCardTekrar, cardAmountsTekrar);
                            else
                                Console.Write("( (cardAmounts[1] - {0}) / cardAmounts[0] ) * ", lastCardTekrar);

                        }
                        else
                        {
                            if (cardAmountsTekrar > 0)
                                Console.Write("( cardAmounts[1] / (cardAmounts[0] - {0}) ) * ", cardAmountsTekrar);
                            else
                                Console.Write("( cardAmounts[1] / cardAmounts[0] ) * ");
                        }

                        probabilityRow *= cardAmounts1 / (cardAmounts[0] - cardAmountsTekrar);
                    }
                    else if (currentCard == 10)
                    {
                        double cardAmounts10s = cardAmounts[10] + cardAmounts[11] + cardAmounts[12] + cardAmounts[13];

                        if (currentCard == lastCard)
                        {
                            cardAmounts10s -= 1;
                            lastCardTekrar++;

                            if (cardAmountsTekrar > 0)
                                Console.Write("(((cardAmounts[10] + cardAmounts[11] + cardAmounts[12] + cardAmounts[13]) - {0}) / (cardAmounts[0] - {1}) ) * ", lastCardTekrar, cardAmountsTekrar);
                            else
                                Console.Write("(((cardAmounts[10] + cardAmounts[11] + cardAmounts[12] + cardAmounts[13]) - {0}) / cardAmounts[0] ) * ", lastCardTekrar);
                        }
                        else
                        {
                            if (cardAmountsTekrar > 0)
                                Console.Write("((cardAmounts[10] + cardAmounts[11] + cardAmounts[12] + cardAmounts[13]) / (cardAmounts[0] - {0}) ) * ", cardAmountsTekrar);
                            else
                                Console.Write("((cardAmounts[10] + cardAmounts[11] + cardAmounts[12] + cardAmounts[13]) / cardAmounts[0] ) * ");
                        }

                        probabilityRow *= cardAmounts10s / (cardAmounts[0] - cardAmountsTekrar);
                    }
                    else
                    {
                        double cardAmountsCurrentCard = cardAmounts[currentCard];
                        if (currentCard == lastCard)
                        {
                            cardAmountsCurrentCard -= 1;
                            lastCardTekrar++;

                            if (cardAmountsTekrar > 0)
                                Console.Write("( (cardAmounts[{0}] - {1}) / (cardAmounts[0] - {2}) ) * ", currentCard, lastCardTekrar, cardAmountsTekrar);
                            else
                                Console.Write("( (cardAmounts[{0}] - {1}) / cardAmounts[0] ) * ", currentCard, lastCardTekrar);
                        }

                        else
                        {
                            if (cardAmountsTekrar > 0)
                                Console.Write("( cardAmounts[{0}] / (cardAmounts[0] - {1})) * ", currentCard, cardAmountsTekrar);
                            else
                                Console.Write("( cardAmounts[{0}] / cardAmounts[0] ) * ", currentCard);
                        }

                        probabilityRow *= cardAmountsCurrentCard / (cardAmounts[0] - cardAmountsTekrar);
                    }

                    lastCard = currentCard;
                    cardAmountsTekrar++;
                }

                lastCardTekrar = 0;

                if (i == liste.Count - 1)
                    Console.Write("\b\b) ;\n");
                else
                    Console.Write("\b\b) +\n");

                probability += probabilityRow;
            }

            return probability;
        }

        public static double GetProbabilityVisualized(double upCard, double goal)
        {
            cardAmounts = new double[14] { 416, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32, 32 };
            List<List<double>> liste;

            if (upCard == 1 || upCard == 11)
            {
                liste = GetAllCombinations(1, goal);
                liste.AddRange(GetAllCombinations(11, goal));
            }
            else
                liste = GetAllCombinations(upCard, goal);


            double probability = 0;

            for (int i = 0; i < liste.Count; i++)
            {
                int cardAmountsTekrar = 0;
                int lastCardTekrar = 0;
                int lastCard = 0;
                double probabilityRow = 1;

                Console.Write(@"// {0} + ",upCard);
                foreach (int currentCard in liste[i])
                {
                    if (currentCard == 1 || currentCard == 11)
                    {
                        double cardAmounts1 = cardAmounts[1];

                        if (currentCard == lastCard)
                        {
                            cardAmounts1 -= 1;
                            lastCardTekrar++;

                        }

                        Console.Write("A ");

                        probabilityRow *= cardAmounts1 / (cardAmounts[0] - cardAmountsTekrar);
                    }
                    else if (currentCard == 10)
                    {
                        double cardAmounts10s = cardAmounts[10] + cardAmounts[11] + cardAmounts[12] + cardAmounts[13];

                        if (currentCard == lastCard)
                        {
                            cardAmounts10s -= 1;
                            lastCardTekrar++;
                        }

                        Console.Write("10 ");

                        probabilityRow *= cardAmounts10s / (cardAmounts[0] - cardAmountsTekrar);
                    }
                    else
                    {
                        double cardAmountsCurrentCard = cardAmounts[currentCard];
                        if (currentCard == lastCard)
                        {
                            cardAmountsCurrentCard -= 1;
                            lastCardTekrar++;
                        }

                        Console.Write("{0} ", currentCard);

                        probabilityRow *= cardAmountsCurrentCard / (cardAmounts[0] - cardAmountsTekrar);
                    }

                    lastCard = currentCard;
                    cardAmountsTekrar++;
                }

                lastCardTekrar = 0;

            //    Console.WriteLine("\n// prob: %{0}\n",probabilityRow*100);

                Console.WriteLine();

                probability += probabilityRow;
            }

            return probability;
        }

        static void Main(string[] args)
        {
            Console.WindowWidth = 200;
            Console.BufferWidth = 250;

            Probabilities.MaxCombinationNumber = 3; // Dealer'ın max kaç kağıt çekerek hedefine ulaşacağı kombinasyonlar.

            double upcard = 4;
            double goal = 20;

            Console.WriteLine();
            double prob = GetProbability(upcard, goal);

            Console.WriteLine("\n\n\n");

            double probControl = GetProbabilityVisualized(upcard, goal);

            Console.WriteLine("\n\n\n");

            Console.WriteLine("{0} TO {1}",upcard,goal);
            Console.WriteLine("PROBABILITY :\t %{0}", prob*100);
            Console.WriteLine("PROB. CONTROL :\t %{0}", probControl*100);
        }
    }
}

