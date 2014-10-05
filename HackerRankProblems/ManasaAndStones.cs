using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    class Solution
    {
        public static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                int numStones = Int32.Parse(Console.ReadLine());
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());

                if (numStones == 1)
                    Console.WriteLine("0");
                else
                {
                    numStones--;
                    List<int> finalStones = new List<int>();

                    for (int x = 0, y = numStones; x <= numStones && y >= 0; x++, y--)
                    {
                        int value = (x * a) + (y * b);

                        if (!finalStones.Contains(value))
                        {
                            finalStones.Add(value);
                        }
                    }

                    finalStones.Sort();

                    foreach (int result in finalStones)
                    {
                        Console.Write("{0} ", result);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
