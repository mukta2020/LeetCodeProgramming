using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class SearchRange
    {

        public int[] SearchRange1(int[] nums, int target)
        {
            int i = 0, j = nums.Length - 1;
            while (i <= j)
            {
                int mid = i + (j - i) / 2;
                if (nums[mid] == target)
                {
                    int start = mid - 1, end = mid + 1;
                    while (start >= 0 && nums[start] == target) start--;
                    while (end < nums.Length && nums[end] == target) end++;
                    return new int[] { start + 1, end - 1 };
                }
                else if (nums[mid] > target)
                {
                    j = mid - 1;
                }
                else
                {
                    i = mid + 1;
                }
            }

            return new int[] { -1, -1 };
        }

    }
}
