using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class MySqrt
    {
        public static int MySqrt1(int x)
        {
            int l = 0, h = x;
            while (l <= h)
            {
                int mid = (l + h) / 2;
                if ((mid == x / mid))
                    return mid;
                else if (mid < x / mid)
                    l = mid + 1;
                else
                    h = mid - 1;
            }
            return h;
        }
        public static int MySqrt2(int x)
        {
            int d = x / 2;
            while (d > 0)
            {
                if (d * d == x) return d;
                else
                    d = d / 2;
            }
            return d;

        }

    }
}
