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
            string[] NumJarsAndTestCases = Console.ReadLine().Split(' ');
            double numJars = double.Parse(NumJarsAndTestCases[0]);
            int operations = Int32.Parse(NumJarsAndTestCases[1]);
            double total = 0.0;

            for (int i = 0; i < operations; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                double a = double.Parse(input[0]);
                double b = double.Parse(input[1]);
                double k = double.Parse(input[2]);

                total = total + ((b - a + 1.0) * k);

                // Console.WriteLine("Total: {0}; a: {1}; b: {2}; k: {3}", total, a, b, k);
            }

            double result = total / numJars;
            // Console.WriteLine("Total: {0}; NumJars: {1}; operations: {2}", total, numJars, operations);
            Console.WriteLine("{0}", Math.Floor(result));
        }
    }
}
