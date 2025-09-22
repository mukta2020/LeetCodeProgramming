using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class MIU
    {
        public static int isSequentiallyBounded(int[] a)
        {
            if (a.Length == 0) return 1;
            int c = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] < 0) return 0;

                if (a[i - 1] > a[i]) return 0;
                else if (a[i - 1] == a[i]) c++;
                else if (a[i - 1] < a[i])
                {
                    if (a[i - 1] <= c) return 0;
                    else c = 1;
                }
            }

            if (c >= a[a.Length - 1]) return 0;
            else return 1;
        }


        public static int isMinMaxDisjoint(int[] a)
        {

            if (a.Length == 0) return 0;
            int min = a.Min();
            int max = a.Max();
            int minC = 0;
            int maxC = 0;
            bool mequal = false;
            bool mAdjacent = false;
            bool minOne = false;
            bool maxOne = false;

            if (min != max) mequal = true;
            if (max - min > 1) mAdjacent = true;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == min) minC++;
                if (a[i] == max) maxC++;
            }

            if (minC == 1) minOne = true;
            if (maxC == 1) maxOne = true;

            if (mequal && mAdjacent && minOne && maxOne)
                return 1;
            else return 0;


        }

        static int isStepped(int[] a) // int[] a = { 1, 1, 1,  5, 5, 8, 8, 8 };
        {
            var hasset = new HashSet<int>(a);

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] < a[i])
                    return 0;
            }

            foreach (int d in hasset)
            {
                if (a.Count(c => c == d) < 3)
                    return 0;
            }

            return 1;
        }
        static int isDigitIncreasing(int n)
        {
            int l = n.ToString().Length;
            string f = n.ToString()[0].ToString();
            for (int i = 1; i <= Convert.ToInt32(f); i++)
            {
                int sum = 0;
                string s = i.ToString();

                for (int j = 0; j < l; j++)
                {
                    sum = sum + Convert.ToInt32(s);
                    s = s + s;
                }
                if (sum == n) return 1;
            }
            return 0;
        }

        static int hasNValue1(int[] a, int n)
        {
            int[] b = new int[n];
            b[0] = a[0];
            int k = 1;

            for (int i = 1; i < a.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < k; j++)
                {
                    if (a[i] == b[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    b[k] = a[i];
                    k++;
                }

            }

            if (k == n)
                return 1;
            else
                return 0;
        }

        static int hasNValue(int[] a, int n)
        {
            var hasset = new HashSet<int>(a);

            if (hasset.Count == n)
            {
                return 1;
            }
            else
                return 0;
        }
        public static int hasNValues(int[] a, int n)
        {
            var h = new HashSet<int>(a);
            if (h.Count == n) return 1;
            else return 0;
        }


        static int is121ArrayFst(int[] a)
        {
            if (a == null) return 0;
            if (a.Length < 3) return 0;

            bool one = false;
            bool two = false;
            int countOne = 0;
            int countOneLast = 0;

            if (a[0] == 1)
            {
                countOne = 1;
                one = true;
            }

            if ((a[0] != 1) || (a[a.Length - 1] != 1))
            {
                return 0;
            }

            for (int i = 1; i < a.Length; i++)
            {
                if ((two == false) && (a[i - 1] == a[i]) && (a[i] == 1))
                    countOne++;
                else if ((two == false) && (a[i] == 2))
                    two = true;
                else if ((two == true) && (a[i - 1] == a[i]) && (a[i] == 2))
                    continue;
                else if ((two == true) && (a[i] == 1))
                    countOneLast++;
                else
                    return 0;
            }

            if ((one && two) && (countOne == countOneLast))
            {
                return 1;
            }
            else
                return 0;
        }

        static int is121Array(int[] a)
        {
            if ((a[0] != 1) || (a[a.Length - 1]) != 1)
            {
                return 0;
            }
            bool one = false;
            bool two = false;

            int countOne = 0;
            int countOneLast = 0;

            int countTwo = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 1)
                {
                    one = true;
                }
                else if (a[i] == 2)
                {
                    two = true;
                }
                else
                    return 0;



                if ((one == true) && (two == false) && (a[i] == 1))
                {
                    countOne++;
                }
                else if ((one == true) && (two == true) && (a[i] == 2) && (countOneLast == 0))
                {
                    countTwo++;
                }
                else if ((one == true) && (two == true) && (a[i] == 1))
                {
                    countOneLast++;
                }
                else
                    return 0;


            }

            if ((one && true) && (countOne == countOneLast))
            {
                return 1;
            }
            else
                return 0;

        }
        static int is121Array2(int[] a)
        {
            Dictionary<int, List<int>> myDic = new Dictionary<int, List<int>>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!myDic.Keys.Contains(a[i]))
                {
                    List<int> l = new List<int>();
                    l.Add(i);
                    myDic.Add(a[i], l);
                }
                else
                {
                    myDic[a[i]].Add(i);
                }
            }

            bool one = false;
            bool two = false;

            foreach (int k in myDic.Keys)
            {
                if (k == 1)
                    one = true;
                else if (k == 2)
                    two = true;
                else
                    return 0;


                if (k == 2)
                {
                    List<int> l2 = myDic[2];
                    for (int j = 0; j < l2.Count - 1; j++)
                    {
                        if (l2[j] + 1 != l2[j + 1])
                        {
                            return 0;
                        }
                    }
                }
                else if (k == 1)
                {
                    List<int> l1 = myDic[1];
                    if (l1.Count % 2 != 0)
                    {
                        return 0;
                    }
                    else
                    {
                        int fstHalf = l1.Count / 2;
                        if ((l1[fstHalf] - l1[fstHalf - 1]) <= 1)
                        {
                            return 0;
                        }
                    }
                }

            }

            if (one || two)
            {
                return 1;
            }
            else
                return 0;
        }

        static int is123Array(int[] a)
        {

            if ((a == null) || (a.Length < 3))
            {
                return 0;
            }

            for (int i = 0; i < a.Length - 2; i += 3)
            {
                if ((a[i] == 1) && (a[i + 1] == 2) && (a[i + 2] == 3))
                    continue;
                else
                    return 0;
            }
            return 1;
        }

        static bool equivalCheck(int[] a1, int[] a2)
        {
            for (int i = 0; i < a1.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < a2.Length; j++)
                {

                    if (a1[i] == a2[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (found == false)
                    return false;
            }
            return true;
        }

        static int equivalantArray(int[] a1, int[] a2)
        {
            bool fstArrayEleFound = equivalCheck(a1, a2);
            bool sndArrayEleFound = equivalCheck(a2, a1);

            if ((fstArrayEleFound == true) && (sndArrayEleFound == true))
                return 1;
            else
                return 0;

        }
        static int is235Array(int[] a)
        {
            int c2 = 0;
            int c3 = 0;
            int c5 = 0;
            int cnot235 = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    c2++;
                }

                if (a[i] % 3 == 0)
                {
                    c3++;
                }

                if (a[i] % 5 == 0)
                {
                    c5++;
                }

                if ((a[i] % 2 != 0) && (a[i] % 3 != 0) && (a[i] % 5 != 0))
                {
                    cnot235++;
                }
            }

            if ((c2 + c3 + c5 + cnot235) == a.Length)
                return 1;
            else
                return 0;

        }


    }
}
