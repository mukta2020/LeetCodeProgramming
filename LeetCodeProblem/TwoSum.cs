using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class TwoSum
    {
        static public int[] TwoSum2(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                int a = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (a + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return null;
        }

        static public int[] TwoSum1(int[] nums, int target)
        {   // [2, 7, 11, 15]
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int num1 = nums[i];
                int num2 = target - num1;
                if (d.Keys.Contains(num2))
                {
                    return new int[] { i, d[num2] };
                }

                d.Add(num1, i);
            }
            return null;
        }

    }
}
