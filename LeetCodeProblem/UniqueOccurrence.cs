using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class UniqueOccurrence
    {
        public static bool UniqueOccurrences(int[] arr)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {

                if (!d.Keys.Contains(arr[i]))
                {
                    d[arr[i]] = 1;
                }
                else
                    d[arr[i]] += 1;
            }
            List<int> v = new List<int>();
            foreach (int item in d.Values)
            {
                v.Add(item);
            }
            HashSet<int> h = new HashSet<int>(v);

            if (v.Count == h.Count)
                return true;
            else
                return false;
        }

    }
}
