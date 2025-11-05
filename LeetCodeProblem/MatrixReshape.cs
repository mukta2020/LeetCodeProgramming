using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class MatrixReshape
    {

        public static int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            if (mat.Length * mat[0].Length != r * c) return mat;

            int[][] a = new int[r][];
            int[] b = new int[c];
            int k = 0;
            int r1 = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    b[k] = mat[i][j];
                    k++;

                    if (k == c)
                    {
                        a[r1] = b;
                        b = new int[c];
                        k = 0;
                        r1++;
                    }
                }

            }

            return a;
        }

        public static int[][] MatrixReshape1(int[][] mat, int r, int c)
        {
            int[][] m = new int[r][];
            int[] col = new int[c];
            int k = 0;
            int r1 = 0;

            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    if (k < c)
                    {
                        col[k] = mat[i][j];
                        k++;
                    }
                    else
                    {
                        m[r1] = col; col = new int[c];
                        k = 0; r1++;
                    }
                }
            }

            if (k == c)
            {
                m[r1] = col;
            }


            return m;
        }


    }
}
