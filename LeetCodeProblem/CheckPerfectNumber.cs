using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class CheckPerfectNumber
    {
        public static bool CheckPerfectNum(int num)
        {
            int s = 1;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    s += num / i;
                }
            }

            if (num == s) return true;
            else return false;
        }

    }
}
