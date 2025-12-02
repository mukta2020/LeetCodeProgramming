using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class LuckyNumber
    {

        public static int FindLucky(int[] arr)
        {

            Dictionary<int, int> d = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {

                if (!d.Keys.Contains(arr[i]))
                {

                    d.Add(arr[i], 1);
                }
                else
                    d[arr[i]] += 1;
            }

            int l = -1;
            foreach (int k in d.Keys)
            {

                if (k == d[k])
                {
                    l = Math.Max(l, k);
                }
            }
            return l;
        }
        public static IList<int> LuckyNumbers(int[][] matrix)
        {
            int row = matrix.Length;
            int col = matrix[0].Length;
            List<int> l = new List<int>();

            for (int r = 0; r < row; r++)
            {
                int minRow = int.MaxValue;
                int[] rr = matrix[r];
                minRow = rr.Min();

                for (int c = 0; c < col; c++)
                {
                    if (matrix[r][c] == minRow)
                    {

                        int maxCol = int.MinValue;
                        for (int i = 0; i < row; i++)
                        {
                            if (matrix[i][c] > maxCol)
                            {
                                maxCol = matrix[i][c];
                            }
                        }
                        if (maxCol == minRow) l.Add(maxCol);
                    }

                }
            }

            return l;
        }

    }
}
