using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class GetRow
    {
        public static IList<int> GetRow1(int rowIndex)
        {
            List<int> a = new List<int>();
            IList<IList<int>> resultList = new List<IList<int>>();

            for (int i = 0; i <= rowIndex; i++)
            {
                a = new List<int>();
                a.Add(1);

                int j = 0;
                for (j = 1; j < i; j++)
                {
                    int k = resultList[i - 1][j - 1] + resultList[i - 1][j];
                    a.Add(k);
                }
                if (i == j)
                {
                    a.Add(1);
                }
                resultList.Add(a);
            }
            return a;
        }

    }
}
