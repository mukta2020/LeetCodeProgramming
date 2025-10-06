using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LeetCodeProblem
{
    public class Anagram
    {
        //Console.WriteLine(Anagram.areAnagrams(new char[] { 's', 'i', 't' }, new char[] { 's', 't', 'i' }));
        static public int areAnagrams(char[] a1, char[] a2)
        {

            if (a1.Length != a2.Length) return 0;

            for (int i = 0; i < a1.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < a2.Length; j++)
                {
                    if (a1[i] == a2[j])
                    {
                        a1[i] = '*';
                        a2[j] = '*';
                        found = true; break;
                    }
                }
                if (found == false) return 0;
            }
            if (a1.SequenceEqual(a2)) return 1;
            else return 0;
        }

        //var strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
        //Console.WriteLine(Anagram.GroupAnagrams(strs));
        static public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

            foreach (string word in strs)
            {
                char[] chars = word.ToCharArray();
                Array.Sort(chars);
                string sortedWord = new string(chars);

                if (!map.ContainsKey(sortedWord))
                {
                    map[sortedWord] = new List<string>();
                }
                map[sortedWord].Add(word);
            }

            return map.Values.ToList<IList<string>>();
        }

    }
}
