using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class PlusOne
    {

        public static int[] PlusOne2(int[] digits)
        {
            //Input: digits = [9,9,9]
            //Output: [1,0,0,0]
            int c = 0;
            if (digits[digits.Length - 1] == 9)
            {
                c = 1; digits[digits.Length - 1] = 0;
            }
            else
            {
                digits[digits.Length - 1] = digits[digits.Length - 1] + 1;
            }

            for (int i = digits.Length - 2; i >= 0; i--)
            {
                if (c == 1 && (digits[i] + c) > 9)
                {
                    digits[i] = 0; c = 1;
                }
                else if (c == 1)
                {
                    digits[i] = digits[i] + c;
                    c = 0;
                }
            }
            if (c == 1)
            {
                int[] d = new int[digits.Length + 1];
                d[0] = c;
                for (int i = 0; i < digits.Length; i++)
                {
                    d[i + 1] = digits[i];
                }
                return d;
            }
            else
            {
                return digits;
            }

        }

        public static int[] PlusOne1(int[] digits)
        {
            string s = "";
            for (int i = 0; i < digits.Length; i++)
            {
                s += digits[i].ToString();
            }

            int d = Convert.ToInt32(s) + 1;
            s = d.ToString();
            int[] r = new int[s.Length];

            int k = r.Length - 1;

            while (d > 0)  // good solution
            {
                r[k] = d % 10;
                d = d / 10;
                k--;
            }


            return r;
        }
    }
}
