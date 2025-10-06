using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Reverse
    {
        static public int reverseNumber(int n)
        {
            int r = 0;
            if (n == 0) return 0;
            int flag = 1;
            if (n < 0)
            {
                n = -n;
                flag = -1;
            }

            while (n > 0)
            {
                int rem = n % 10;
                n = n / 10;
                r = r * 10 + rem;
            }

            return flag * r;

        }

        // for positive number
        static public int Reverse1(int a)
        {

            int r = 0;
            while (a > 0)
            {
                int rem = a % 10;
                a = a / 10;
                r = r * 10 + rem;
            }
            return r;
        }
    }
}
