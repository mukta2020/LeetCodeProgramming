using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class pow
    {

        public static int MyPow(int x, int n)  //2 * 2 *2
        {
            int r = 1;
            for (int i = 0; i < n; i++) 
            {
                r *= x;            
            }
            return r;
        }
    }
}

