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
            string[] MN = Console.ReadLine().Split(' ');
            int arraySize = Int32.Parse(MN[0]);
            int operations = Int32.Parse(MN[1]);
            double[] bigArray = new double[arraySize];
            double maxAmount = 0;

            for (int i = 0; i < operations; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int a = Int32.Parse(input[0]);
                int b = Int32.Parse(input[1]);
                double amount = double.Parse(input[2]);

                for (int x = a - 1; x <= b - 1; x++)
                {
                    bigArray[x] += amount;

                    if (bigArray[x] > maxAmount)
                        maxAmount = bigArray[x];
                }
            }

            Console.WriteLine(maxAmount);
        }
    }
}
