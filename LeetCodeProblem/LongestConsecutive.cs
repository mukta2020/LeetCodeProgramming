using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class LongestConsecutive
    {
        public static int LongestConsecutives(int[] nums)
        {
            HashSet<int> h = new HashSet<int>(nums);

            int lc = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int ele = nums[i];
                if (!h.Contains(ele - 1))
                {
                    int c = 0;
                    while (h.Contains(ele))
                    {
                        c += 1;
                        ele += 1;
                    }
                    lc = Math.Max(lc, c);
                }

            }
            return lc;
        }

    }
}
