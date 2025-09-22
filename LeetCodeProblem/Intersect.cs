using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Intersect
    {
        public static int[] IntersectHelper(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic1 = new Dictionary<int, int>();
            Dictionary<int, int> dic2 = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!dic1.ContainsKey(nums1[i]))
                {
                    dic1.Add(nums1[i], 1);
                }
                else
                {
                    dic1[nums1[i]] += 1;
                }
            }
            for (int i = 0; i < nums2.Length; i++)
            {
                if (!dic2.ContainsKey(nums2[i]))
                {
                    dic2.Add(nums2[i], 1);
                }
                else
                {
                    dic2[nums2[i]] += 1;
                }
            }

            int[] inter = new int[nums2.Length];
            int count = 0;
            foreach (int k in dic1.Keys)
            {
                if (dic2.ContainsKey(k))
                {
                    int c = dic1[k] < dic2[k] ? dic1[k] : dic2[k];
                    for (int p = 0; p < c; p++)
                    {
                        inter[count] = k;
                        count++;
                    }
                }
            }

            int[] ret = new int[count];
            for (int i = 0; i < count; i++)
            {
                ret[i] = inter[i];
            }

            return ret;
        }

        public static int[] IntersectArray(int[] nums1, int[] nums2)
        {

            if (nums1.Length > nums2.Length)
            {
                return IntersectHelper(nums1, nums2);
            }
            else
            {
                return IntersectHelper(nums2, nums1);
            }

        }

    }
}
