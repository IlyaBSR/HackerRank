using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    public class Solution
    {
        public static void Main(String[] args)
        {
            // Grab inputs
            int numberOfInputs = Int32.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            // Split the inputs to their integer values stored in a list named Sticks
            string[] inputStrings = input.Split(' ');
            int[] sticks = new int[inputStrings.Length];
            int smallestValue = -1;

            for (int i = 0; i < inputStrings.Length; i++)
            {
                int value = Int32.Parse(inputStrings[i]);
                sticks[i] = value;

                if (smallestValue == -1 || smallestValue > value)
                {
                    smallestValue = value;
                }
            }

                CutOperation(sticks, smallestValue);
        }

        private static void CutOperation(int[] sticks, int minValue)
        {
            int cuts = 0;
            int validSticks = 0;
            int smallestValue = -1;
            for (int i = 0; i < sticks.Length; i++) 
            {
                if (sticks[i] <= 0)
                    continue;
                
                sticks[i] = sticks[i] - minValue;
                cuts++;

                if (sticks[i] > 0)
                {
                    validSticks++;

                    if (smallestValue == -1)
                    {
                        smallestValue = sticks[i];
                    }
                    else if (smallestValue > sticks[i])
                    {
                        smallestValue = sticks[i];
                    }
                }
            }

            Console.WriteLine(cuts);

            if (validSticks > 0)
            {
                CutOperation(sticks, smallestValue);
            }
        }
    }
}
