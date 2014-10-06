using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());
            Dictionary<ulong, double> squareValues = new Dictionary<ulong, double>();
            squareValues.Add(0, 4);
            squareValues.Add(1, 6);
            squareValues.Add(2, 10);
            ulong mod = 1000000007;

            for (int i = 0; i < testCases; i++)
            {
                ulong input = ulong.Parse(Console.ReadLine());

                if (!squareValues.ContainsKey(input))
                {
                    for (ulong seconds = squareValues.Keys.Max() + 1; seconds <= input; seconds++)
                    {
                        squareValues.Add(seconds, (squareValues[seconds - 1] + ModPow(2, seconds, mod)) % mod);
                    }
                }
                
                Console.WriteLine(squareValues[input]);
            }
        }

        private static ulong ModPow(ulong baseValue, ulong exponent, ulong modulous)
        {
            ulong result = 1;
            while (exponent > 0)
            {
                if (exponent % 2 == 1)
                    result = (result * baseValue) % modulous;
                exponent = exponent >> 1;
                baseValue = (baseValue * baseValue) % modulous;
            }

            return result;
        }
    }
}
