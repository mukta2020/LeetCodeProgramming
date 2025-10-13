using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class RemoveDuplicates
    {


        //public int removeDuplicatesMedium(int[] nums)
        //{
        //    int NoDA = 2; //No of duplicates allowed
        //    if (nums.Length < NoDA) return nums.Length;
        //    //This is a generic solution
        //    //if you replace NoDA value to 1, it is solution for "26. Remove Duplicates from Sorted Array"
        //    //Based on the number of duplicates allowed, It can be replaced with 3, 4, 5, .....
        //    int P1 = NoDA, P2 = NoDA; //2-pointers, both starting at NoDA
        //    while (P2 < nums.Length)
        //    {
        //        if (nums[P2] != nums[P1 - NoDA])
        //        {
        //            nums[P1] = nums[P2];
        //            P1++;
        //        }
        //        P2++;
        //    }
        //    return P1;
        //}

        public static int removeDuplicatesMedium(int[] nums)
        {
            int n = 2; //No of duplicates allowed
            if (nums.Length < n) return nums.Length;
            int P1 = n;
            for (int P2 = n; P2 < nums.Length; P2++)
            {
                if (nums[P2] != nums[P1 - n])
                {
                    nums[P1] = nums[P2];
                    P1++;
                }
            }
            return P1;
        }
        public int RemoveDuplicates1(int[] nums)
        {
            int i = 1;
            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j - 1] != nums[j])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }

        public static int removeDuplicates1(int[] nums)
        {
            int i = 1;  // i for unique,  j  moving  {1,1,2,2,3,3}

            for (int j = 1; j < nums.Length; j++)
            {
                if (nums[j - 1] != nums[j])
                {
                    nums[i] = nums[j]; // unique value assignment
                    i++;               // unique index increasing
                }
            }
            return i;
        }


        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;   // i for non-removal element count,  j  for full looping on  {3,2,2,3} val = 3
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != val) // taking action for non-removal element
                {
                    int t = nums[j];
                    nums[j] = nums[i];
                    nums[i] = t;
                    i++;
                }
            }
            return i;
        }


    }
}
