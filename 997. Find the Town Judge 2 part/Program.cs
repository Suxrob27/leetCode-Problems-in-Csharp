using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _997.Find_the_Town_Judge_2_part
{
    public class Program
    {
        public class Solution
        {
            public int FindJudge(int n, int[][] trust)
            {
                int[] trustCount = new int[n + 1];
                HashSet<int> candidates = new HashSet<int>();

                foreach (var relation in trust)
                {
                    int a = relation[0];
                    int b = relation[1];

                    trustCount[b]++;
                    candidates.Add(a);
                }

                for (int i = 1; i <= n; i++)
                {
                    if (trustCount[i] == n - 1 && !candidates.Contains(i))
                    {
                        return i;
                    }
                }

                return -1;
            }
        }
        static void Main(string[] args)
        {
            int[][] inhabitants = new int[4][];
            {
                inhabitants[0] = new int[] { 0, 1 };
                inhabitants[1] = new int[] { 4, 1 };
                inhabitants[2] = new int[] { 3, 1 };
                inhabitants[3] = new int[] { 2, 1 };
            }

            Solution sl = new Solution();
            sl.FindJudge(1, inhabitants);
        }
    }
}
