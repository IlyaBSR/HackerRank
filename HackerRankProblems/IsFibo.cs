using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());
            List<double> fibs = new List<double>();
            fibs.Add(0);
            fibs.Add(1);
            fibs.Add(1);

            for (int i = 0; i < testCases; i++)
            {
                double input = double.Parse(Console.ReadLine());

                while (fibs.Last() < input)
                {
                    fibs.Add(fibs[fibs.Count - 1] + fibs[fibs.Count - 2]);
                }

                if (fibs.Contains(input))
                {
                    Console.WriteLine("IsFibo");
                }
                else
                {
                    Console.WriteLine("IsNoFibo");
                }
            }
        }
    }
}
