using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class WordBreak
    {
      
        public bool WordBreak2(string s, IList<string> wordDict)
        {
            var res = new bool[s.Length + 1];
            res[s.Length] = true;

            for (int i = s.Length - 1; i >= 0; i--)
            {
                foreach (var w in wordDict)
                {
                    if (i + w.Length <= s.Length && w == s.Substring(i, w.Length))
                    {
                        res[i] = res[i + w.Length];
                    }

                    if (res[i])
                    {
                        break;
                    }
                }
            }

            return res[0];
        }

        public static bool WordBreak1(string s, IList<string> wordDict)
        {
            int totalLength = 0;
            foreach (var word in wordDict)
            {
                totalLength += word.Length;
            }

            if (totalLength > s.Length)
            {
                return false;
            }

            // s = "applepenapple", wordDict = ["apple","pen"]   apple pen bd apple
            // s = "leetcode", wordDict = ["leet","code"]

            foreach (var word in wordDict)
            {
                if (!s.Contains(word))
                {
                    return false;
                }
                else
                {

                }
            }


            return false;
        }



    }
}
