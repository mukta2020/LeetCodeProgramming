using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class ThirdMax
    {
        public static int ThirdMax2(int[] nums)
        {
            nums = nums.OrderBy(x => x).Distinct().ToArray();
            if (nums.Length < 3)
            {
                return nums.Max();
            }
            else
            {
                return nums[nums.Length - 3];
            }
        }

        public static int ThirdMax1(int[] nums)
        {
            long max = long.MinValue;
            long secondMax = long.MinValue;
            long thirdMax = long.MinValue;
            foreach (var num in nums)
            {
                if (num > max)
                {
                    thirdMax = secondMax;
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num < max)
                {
                    thirdMax = secondMax;
                    secondMax = num;
                }
                else if (num > thirdMax && num < secondMax)
                {
                    thirdMax = num;
                }
            }
            return thirdMax == long.MinValue ? (int)max : (int)thirdMax;
        }


        public static (int[], int) ThirdMaxHelper(int[] nums)
        {
            int one = nums.Max();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == one)
                {
                    nums[i] = int.MinValue;
                }
            }
            return (nums, one);
        }
        public static int ThirdMax3(int[] nums)
        {
            int fstMax = ThirdMaxHelper(nums).Item2;
            int sndMax = ThirdMaxHelper(nums).Item2;
            int trdMax = ThirdMaxHelper(nums).Item2;

            if (nums.Length < 3)
                return fstMax;
            else
                return trdMax >= int.MinValue ? trdMax : fstMax;
        }
    }
}
