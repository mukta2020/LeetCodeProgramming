using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class LongestCommonPrefix
    {
        public static string LongestCommonPrefix1(string[] strs)
        {
            string c = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                int l = c.Length < strs[i].Length ? c.Length : strs[i].Length;

                string com = ""; string item = strs[i];
                for (int j = 0; j < l; j++)
                {
                    if (c[j] == item[j]) com += c[j];
                    else break;
                }
                c = com;
            }
            return c;
        }
    }
}
