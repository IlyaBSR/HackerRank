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
    class Solution
    {
        /*
         * Complete the function below.
         */
        static int maxXor(int l, int r)
        {
            int max = 0;
            for (int x = l; x <= r; x++ )
                for (int i = x + 1; i <= r; i++)
                {
                    int result = x ^ i;
                    if (result > max)
                        max = result;
                }

            return max;
        }

        static void Main(String[] args)
        {
            int res;
            int _l;
            _l = Convert.ToInt32(Console.ReadLine());

            int _r;
            _r = Convert.ToInt32(Console.ReadLine());

            res = maxXor(_l, _r);
            Console.WriteLine(res);

        }
    }
}
