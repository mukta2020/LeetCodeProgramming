using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class ToeplitzMatrix
    {
        public static bool IsToeplitzMatrix(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < cols - 1; c++)
                {
                    if (matrix[r][c] != matrix[r + 1][c + 1])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsToeplitzMatrix2(int[][] matrix)
        {
            for (int r = 0; r < matrix.Length; r++)
                for (int c = 0; c < matrix[0].Length; c++)
                    if (r > 0 && c > 0 && matrix[r - 1][c - 1] != matrix[r][c])
                        return false;
            return true;
        }
    }
}
