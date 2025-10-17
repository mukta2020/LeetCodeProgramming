using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class ReverseWords
    {
        static public string ReverseWords1(string s)
        {
            s.Trim(' ');
            string str = "";
            var words = s.Split(' ');
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (words[i] == "")
                    continue;
                str += words[i] + " ";
            }
            return str.Trim();

        }
    }
}
