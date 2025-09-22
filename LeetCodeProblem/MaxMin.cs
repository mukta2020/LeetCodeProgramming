using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class MaxMin
    {
        static public Tuple<int, int> MaxMinValue(int[] a)
        {
            int maxV = int.MinValue;
            int minV = int.MaxValue;

            for (int i = 0; i < a.Length; i++)
            {

                if (a[i] > maxV)
                {
                    maxV = a[i];
                }

                if (a[i] < minV)
                {
                    minV = a[i];
                }
            }
            return new Tuple<int, int>(maxV, minV);
        }

    }
}
