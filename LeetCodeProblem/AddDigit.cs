using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class AddDigit
    {
        public static int AddDigits(int num)
        {
            while (num > 9)
            {
                string s = num.ToString();
                int total = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    int d = Convert.ToInt32(s[i].ToString());
                    total += d;
                }
                num = total;
            }
            return num;

        }
    }
}
