using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    public class Solution
    {
        static void Main(String[] args)
        {
            // Grab the number of test cases coming in
            int testCases = Convert.ToInt32(Console.ReadLine());

            // Perform this task for each input
            for (int i = 0; i < testCases; i++)
            {
                string input = Console.ReadLine();
                int operations = 0;
                for (int x = 0; x < input.Length / 2; x++)
                {
                    // If the characters on opposite ends are equal do nothing
                    if (input[x].Equals(input[input.Length - 1 - x]))
                    {
                        continue;
                    }

                    int front = Convert.ToInt32(input[x]);
                    int end = Convert.ToInt32(input[input.Length - 1 - x]);

                    // If the the left side is a greater character reduce it till its equal
                    while (front > end)
                    {
                        front--;
                        operations++;
                    }

                    while (end > front)
                    {
                        end--;
                        operations++;
                    }
                }

                Console.WriteLine(operations);
            }
        }
    }
}
