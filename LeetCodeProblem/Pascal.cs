using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Pascal
    {
        public static int[,] pascal(int n)
        {
            int[,] a = new int[n, n];

            a[0, 0] = 1;

            for (int i = 1; i < n; i++)
            {
                a[i, 0] = 1;  // 1st element of each row is always 0

                for (int j = 1; j < i; j++)
                {
                    a[i, j] = a[i - 1, j - 1] + a[i - 1, j];
                }

                a[i, i] = 1; // laast element of each row is always 0
            }

            return a;
        }

        // pascal row fixed column dynamic

        public static int[][] Pascal2(int n)
        {
            int[][] m = new int[n][];

            for (int r = 0; r < n; r++)
            {
                int[] a = new int[r + 1];
                a[0] = 1;
                a[r] = 1;

                for (int c = 1; c < r; c++)
                {
                    a[c] = m[r - 1][c - 1] + m[r - 1][c];
                }
                m[r] = a;
            }
            return m;
        }

        // pascal row fixed column dynamic  IList<IList<int>> 

        List<List<int>> pascalList(int numRows)
        {
            List<List<int>> a = new List<List<int>>();

            for (int i = 0; i < numRows; i++)
            {
                int[] innerArray = new int[i + 1];
                innerArray[0] = 1;

                for (int j = 1; j < i; j++)
                {
                    innerArray[j] = a[i - 1][j - 1] + a[i - 1][j];
                }
                innerArray[i] = 1;
                a.Add(innerArray.ToList());
            }
            return a;
        }

        IList<IList<int>> pascalIList(int numRows)
        {
            IList<IList<int>> a = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                int[] innerArray = new int[i + 1];
                innerArray[0] = 1;

                for (int j = 1; j < i; j++)
                {
                    innerArray[j] = a[i - 1][j - 1] + a[i - 1][j];
                }
                innerArray[i] = 1;
                a.Add(innerArray);
            }
            return a;
        }
    }
}
