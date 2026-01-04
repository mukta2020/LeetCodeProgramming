using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Pascal
    {
        // pascal row column fixed size JAVA type

        public static int[,] pascal(int n)
        {
            int[,] m = new int[n, n];

            m[0, 0] = 1;

            for (int r = 1; r < n; r++)
            {
                m[r, 0] = 1;  // 1st element of each row is always 0

                for (int c = 1; c < r; c++)
                {
                    m[r, c] = m[r - 1, c - 1] + m[r - 1, c];
                }

                m[r, r] = 1; // last element of each row is always 0
            }

            return m;
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
            List<List<int>> m = new List<List<int>>();

            for (int r = 0; r < numRows; r++)
            {
                int[] a = new int[r + 1];
                a[0] = 1;

                for (int c = 1; c < r; c++)
                {
                    a[c] = m[r - 1][c - 1] + m[r - 1][c];
                }
                a[r] = 1;
                m.Add(a.ToList());
            }
            return m;
        }

        IList<IList<int>> pascalIList(int numRows)
        {
            IList<IList<int>> m = new List<IList<int>>();

            for (int r = 0; r < numRows; r++)
            {
                int[] a = new int[r + 1];
                a[0] = 1;

                for (int c = 1; c < r; c++)
                {
                    a[c] = m[r - 1][c - 1] + m[r - 1][c];
                }
                a[r] = 1;
                m.Add(a);
            }
            return m;
        }
    }
}
