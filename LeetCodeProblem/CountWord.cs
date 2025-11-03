using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class CountWord
    {
        public static int CountWords(string[] w1, string[] w2)
        {
            int r = 0;

            Dictionary<string, int> d1 = new Dictionary<string, int>();
            Dictionary<string, int> d2 = new Dictionary<string, int>();
            foreach (string s in w1)
                if (!d1.ContainsKey(s))
                    d1.Add(s, 1);
                else
                    d1[s]++;

            foreach (string s in w2)
                if (!d2.ContainsKey(s))
                    d2.Add(s, 1);
                else
                    d2[s]++;

            foreach (KeyValuePair<string, int> e in d1)
            {
                if (e.Value > 1) continue;
                else if (d2.ContainsKey(e.Key) && d2[e.Key] == 1) r++;
            }

            return r;
        }

        // string[] words1 = { "leetcode", "is", "amazing", "as", "is" };
        // string[] words2 = { "amazing", "leetcode", "is" };
        // Console.WriteLine(CountWords(words1, words2));
    }
}
