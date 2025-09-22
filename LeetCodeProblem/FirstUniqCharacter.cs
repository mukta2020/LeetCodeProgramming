using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class FirstUniqCharacter
    {
        static public int FirstUniqChar(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (!map.Keys.Contains(s[i]))
                    map.Add(s[i], 1);
                else
                    map[s[i]] += 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (map[s[i]] == 1)
                    return i;
            }
            return -1;
        }

    }
}
