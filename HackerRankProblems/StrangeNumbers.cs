using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRankProblems
{
    class Solution
    {
        private static HashSet<double> StrangeNum = new HashSet<double>();

        public static void Main(string[] args)
        {
            int testCases = Int32.Parse(Console.ReadLine());

            for (int i = 0; i < testCases; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                double left;
                double right = double.Parse(input[1]);
                StrangeNum.Add(0);
                StrangeNum.Add(1);
                StrangeNum.Add(2);
                StrangeNum.Add(3);
                StrangeNum.Add(4);
                StrangeNum.Add(5);
                StrangeNum.Add(6);
                StrangeNum.Add(7);
                StrangeNum.Add(8);
                StrangeNum.Add(9);

                int strangeCount = 0;

                for (left = double.Parse(input[0]); left <= right; left++)
                {
                    if (IsStrange(left))
                    {
                        strangeCount++;
                        Console.WriteLine(left);
                        double digits = NumDigits(left);
                        if (digits >= 5)
                        {
                            left += Math.Pow(10, digits - 2);
                        }
                    }
                }

                Console.WriteLine(strangeCount);
            }
        }

        private static bool IsStrange(double input)
        {
            if (StrangeNum.Contains(input))
            { 
                return true;
            }
            
            double numDigits = NumDigits(input);

            if (numDigits >= 5 && input % 10 != 0)
            {
                return false;
            }

            if (input % 2 == 0 & input % numDigits == 0 && IsStrange(input / numDigits))
            {
                StrangeNum.Add(input);
                return true;
            }

            return false;
        }

        private static double NumDigits(double number)
        {
            if (number > 0)
            {
                return Math.Floor(Math.Log10(number) + 1);
            }

            if (number == 0)
                return 1.0;

            throw new ArgumentException();
        }
    }
}
