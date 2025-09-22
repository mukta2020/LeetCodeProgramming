using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class DisappearedNumbers
    {
        static public IList<int> FindDisappearedNumbers1(int[] nums)
        {
            int i = 0;
            while (i < nums.Length)
            {
                if (nums[i] == i + 1)
                {
                    i++;
                    continue;
                }

                if (nums[nums[i] - 1] == nums[i])
                {
                    i++;
                }
                else
                {
                    int j = nums[i];
                    int temp = nums[j - 1];
                    nums[j - 1] = nums[i];
                    nums[i] = temp;
                }
            }
            IList<int> list = new List<int>();
            for (i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    list.Add(i + 1);
                }
            }
            return list;

        }

        static public List<int> findDisappearedNumbers(int[] nums)
        {
            List<int> ans = new List<int>();

            int[] idx = new int[nums.Length + 1];

            foreach (int x in nums)
            {
                idx[x]++;
            }


            for (int i = 1; i < idx.Length; i++)
            {
                if (idx[i] == 0)
                {
                    ans.Add(i);
                }
            }

            return ans;
        }

        private static IList<int> FindDisappearedNumbers22(int[] nums)
        {
            List<int> l = new List<int>();

            int max = nums.Length;

            for (int i = 1; i <= max; i++)
            {
                if (!nums.Contains(i))
                {
                    l.Add(i);
                }
            }
            return l;
        }

    }
}
