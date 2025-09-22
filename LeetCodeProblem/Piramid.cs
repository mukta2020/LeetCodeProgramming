using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Piramid
    {
        public static void piramid1(int n)
        {
            /*
            1
            2 2
            3 3 3
            
             */
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }

        public static void piramid2(int row)
        {
            /*
             1
             2 3
             4 5 6
             7 8 9 10
            
             */
            int c = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(c++ + " ");
                }
                Console.WriteLine();
            }
        }

        public static void piramid3(int row)
        {
            /*
              1
             2 3
            4 5 6
           7 8 9 10
            
             */
            int space = row - 1;
            int c = 1;
            for (int i = 1; i <= row; i++)
            {
                for (int s = 0; s < space; s++)
                {
                    Console.Write(0 + " ");
                }
                space--;

                for (int j = 0; j < i; j++)
                {
                    Console.Write(c++ + " ");
                    Console.Write(0 + " ");
                }
                Console.WriteLine();
            }
        }

        public static void piramid4(int row)
        {
            /*
             1 2 3 4
               5 6 7
                 8 9  
                   10            
             */
            int c = 1;
            int r = row;
            int space = 0;

            for (int i = 1; i <= row; i++)
            {
                for (int s = 0; s < space; s++)
                {
                    Console.Write(0 + " ");
                }

                for (int j = 0; j < r; j++)
                {
                    Console.Write(c++ + " ");
                }
                r--;
                space++;
                Console.WriteLine();
            }
        }
    }
}
