using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Palindrome
    {
        public static bool IsPalindrome(int x)
        {
            string s = x.ToString();
            int l = s.Length - 1;  //3

            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[l])
                {
                    return false;
                }
                l--;
            }
            return true;
        }
    }
}
