using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Happy
    {
        public static bool IsHappy(int n)
        {
            int i = 0;
            while (i < 50 && n != 0)
            {
                if (n == 1) { return true; }
                string s = n.ToString();
                int sum = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    int d = Convert.ToInt32(s[j].ToString());
                    sum += d * d;
                }
                n = sum;
                i++;
            }
            return false;

        }

    }
}
