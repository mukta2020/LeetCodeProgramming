using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class rorateArray
    {

        // ---------------Copilot Solution-----------------
        static public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }
        static private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
        //---------------------My solution
        public void Rotate1(int[] nums, int k)
        {
            for (int j = 0; j < k; j++)
            {
                int hand = nums[nums.Length - 1];
                int t = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    t = nums[i];
                    nums[i] = hand;
                    hand = t;
                }
            }

        }

        public void rotate2(int[] nums, int k)
        {
            //https://leetcode.com/problems/rotate-array/solutions/5550096/video-using-remainder-with-3-solutions/?envType=study-plan-v2&envId=top-interview-150
            int n = nums.Length;
            k = k % n;
            int[] rotated = new int[n];

            for (int i = 0; i < n; i++)
            {
                rotated[(i + k) % n] = nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = rotated[i];
            }
        }

        static public void rotate(int[] nums, int k)
        {
            k %= nums.Length;
            int n = nums.Length;
            reverseNum(nums, 0, n - 1);
            reverseNum(nums, 0, k - 1);
            reverseNum(nums, k, n - 1);
        }
        static public void reverseNum(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }



    }
}
