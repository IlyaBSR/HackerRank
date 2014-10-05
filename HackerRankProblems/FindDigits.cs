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
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                int number = Int32.Parse(input);
                int count = 0;
                foreach (char s in input)
                {
                    int digit = Convert.ToInt32(s.ToString());
                    if (digit > 0 && number % digit == 0)
                        count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
