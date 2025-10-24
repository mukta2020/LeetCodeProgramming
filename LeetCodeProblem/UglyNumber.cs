using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class UglyNumber
    {
        public static bool IsUgly(int n)
        {

            while (n > 0)
            {
                if (n == 1) return true;
                if (n % 2 == 0)
                    n = n / 2;
                else if (n % 3 == 0)
                    n = n / 3;
                else if (n % 5 == 0)
                    n = n / 5;
                else
                    return false;
            }
            return false;

        }
    }
}
