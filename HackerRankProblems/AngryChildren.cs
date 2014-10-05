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
            int numPackets = Int32.Parse(Console.ReadLine());
            int picks = Int32.Parse(Console.ReadLine());

            List<double> packets = new List<double>();

            for (int i = 0; i < numPackets; i++)
            {
                double packet = Double.Parse(Console.ReadLine());
                packets.Add(packet);
            }

            packets.Sort();
            double unFairness = -1;

            for (int end = picks - 1, start = 0; end < numPackets; end++, start++)
            {
                double value = packets[end] - packets[start];

                if (unFairness == -1 || value < unFairness)
                    unFairness = value;
            }

            Console.WriteLine(unFairness);
        }
    }
}
