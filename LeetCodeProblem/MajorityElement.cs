using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class MajorityElement
    {
        static public IList<int> MajorityElements(int[] nums)
        {
            var hashSet = new HashSet<int>(nums);
            int size = nums.Length / 3;
            List<int> a = new List<int>();

            foreach (int ele in hashSet)
            {
                if (nums.Count(c => c == ele) > size)
                {
                    a.Add(ele);
                }
            }
            return a;
        }

    }
}
