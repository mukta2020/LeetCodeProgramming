using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class SingleNumber
    {
        public static int SingleNumber1(int[] nums)
        {

            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {

                if (!d.Keys.Contains(nums[i]))
                {
                    d[nums[i]] = 1;
                }
                else
                {
                    d[nums[i]] += 1;
                }
            }

            foreach (int k in d.Keys)
            {
                if (d[k] == 1)
                {
                    return k;
                }
            }

            return 0;
        }

        public static int SingleNumber2(int[] nums)
        {
                       
            HashSet<int> h = new HashSet<int>(nums);

            foreach (int k in h)
            {
                int c = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == k)
                    {
                        c += 1;
                    }
                }
                if (c == 1)
                {
                    return k;
                }
            }

            return 0;
        }

        public static int SingleNumber3(int[] nums)
        {
            HashSet<int> h = new HashSet<int>(nums);

            foreach (int k in h)
            {
                int c = nums.Count(n => n == k);
                
                if (c == 1)
                {
                    return k;
                }
            }

            return 0;
        }

    }
}
