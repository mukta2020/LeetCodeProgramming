using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class HammingDistance
    {

        public int hammingDistance(int x, int y)
        {
            int count = 0;
            while (x > 0 || y > 0)
            {
                if (x % 2 != y % 2) count++;
                x /= 2;
                y /= 2;
            }
            return count;
        }

        static public int TotalHammingDistance(int[] nums)
        {
            int total = 0; ;
            for (int i = 0; i <= nums.Length - 2; i++)
            {

                for (int j = i + 1; j <= nums.Length - 1; j++)
                {
                    int x = nums[i];
                    int y = nums[j];
                    int count = 0;
                    while (x > 0 || y > 0)
                    {
                        if (x % 2 != y % 2) count++;
                        x /= 2;
                        y /= 2;
                    }
                    total += count;
                }
            }
            return total;

        }

    }
}
