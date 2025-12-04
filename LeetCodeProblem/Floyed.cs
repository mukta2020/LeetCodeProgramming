using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Floyed
    {
        public static void Floyed2(int n)
        {
            int x = 1;
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < r + 1; c++)
                {
                    Console.Write(x + " ");
                    x++;
                }
                Console.WriteLine();
            }
        }

        public static int[][] Floyed1(int n)
        {
            int[][] m = new int[n][];
            int x = 1;
            for (int r = 0; r < n; r++)
            {
                int[] a = new int[r + 1];

                if (r % 2 == 0) x = 1;
                else x = 0;

                for (int c = 0; c < r + 1; c++)
                {
                    a[c] = x;
                    x = x == 1 ? 0 : 1;
                }
                m[r] = a;
            }

            return m;

        }

    }
}
