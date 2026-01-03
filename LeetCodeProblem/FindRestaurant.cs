using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class FindRestaurants
    {
        public static string[] FindRestaurant(string[] list1, string[] list2)
        {
            int leastIndexSum = int.MaxValue;
            List<string> l = new List<string>();

            for (int i = 0; i < list1.Length; i++)
            {
                string item = list1[i];
                for (int j = 0; j < list2.Length; j++)
                {
                    if (item == list2[j])
                    {
                        if ((i + j) == leastIndexSum)
                        {
                            l.Add(item);
                            leastIndexSum = i + j;
                        }
                        else if ((i + j) < leastIndexSum)
                        {
                            if (l.Count > 0)
                            {
                                l.RemoveAt(l.Count - 1);
                            }
                            l.Add(item);
                            leastIndexSum = i + j;
                        }
                    }

                }

            }
            return l.ToArray();

        }

    }
}
