using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    internal class MinimumTotal
    {
        // two D array IList<IList<int>>
        public static int MinimumTotal1(IList<IList<int>> triangle)
        {
            int minTotal = 0;
            for (int i = 0; i < triangle.Count; i++)
            {
                List<int> singleRow = triangle[i].ToList();
                minTotal += singleRow.Min();
            }
            return minTotal;
        }

        // two D array int[][]
        public static int MinimumTotal2(int[][] array)
        {
            int minTotal = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int[] singleRow = array[i];
                minTotal += singleRow.Min();

            }
            return minTotal;
        }

        // two D array int[,] 
        public static int MinimumTotal3(int[,] array)
        {
            int minTotal = 0;

            int col = array.GetLength(1);
            int row = array.GetLength(0);

            for (int i = 0; i < row; i++)
            {
                int[] singleRow = new int[col];
                int k = 0;

                for (int j = 0; j < col; j++)
                {
                    singleRow[k++] = array[i, j];

                }
                minTotal += singleRow.Min();

            }

            return minTotal;
        }

        // leetcode 
        public static int MinimumTotal1(int[][] triangle)
        {
            int l = triangle.Length;
            for (int i = l - 1; i > 0; i--)
            {
                for (int j = 0; j < triangle[i].Length - 1; j++)
                {
                    int m = triangle[i][j] < triangle[i][j + 1] ? triangle[i][j] : triangle[i][j + 1];
                    triangle[i - 1][j] += m;
                }
            }
            return triangle[0][0];
        }

        public static int MinimumTotal2(IList<IList<int>> triangle)
        {
            int l = triangle.Count;
            for (int i = l - 1; i > 0; i--)
            {
                for (int j = 0; j < triangle[i].Count - 1; j++)
                {
                    int m = triangle[i][j] < triangle[i][j + 1] ? triangle[i][j] : triangle[i][j + 1];
                    triangle[i - 1][j] += m;
                }
            }
            return triangle[0][0];
        }

    }
}
