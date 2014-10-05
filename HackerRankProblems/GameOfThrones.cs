using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public class Solution
    {
    
        static void Main(String[] args) {
            string input = Console.ReadLine();

            Dictionary<char, int> counts = new Dictionary<char,int>();

            // Have a count of the number of intances for each character
            foreach (char c in input) 
            {
                if (counts.ContainsKey(c))
                {
                    counts[c] = counts[c] + 1;
                }
                else
                {
                    counts.Add(c, 1);
                }
            }

            // Find if there are more than 1 odd number of instances in counts dictionary
            int odds = 0;
            foreach (char c in counts.Keys)
            {
                if (counts[c] % 2 == 1)
                    odds++;
            }

            if (odds > 1)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
