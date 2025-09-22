using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class Prime
    {
        static bool isPrime(int n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        static int isPrimeHappy(int n)
        {
            int primeSum = 0;
            for (int i = 2; i < n; i++)
            {
                if (isPrime(i))
                    primeSum += i;
            }

            if (primeSum % n != 0)
                return 0;

            return 1;
        }
    }
}
