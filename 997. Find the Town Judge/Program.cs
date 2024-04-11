using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _997.Find_the_Town_Judge
{
    public class Solution
    {
        public int FindJudge(int n, int[][] trust)
        {
            bool[] trustSomeOne = new bool[n + 1];
            int[] trustedBy = new int[n + 1];

            foreach (var pair in trust)
            {
                trustSomeOne[pair[0]] = true;
                trustedBy[1]++;
            }

            int judge = -1;

            for (int i = 0; i < n; i++)
            {
                if (trustedBy.Length == n && !trustSomeOne[i])
                {
                  if(judge  == -1)
                        judge = i; 
                  return judge; 
                }
            }

            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[][] inhabitants = new int[4][];
            {
                inhabitants[0] = new int[] { 0,1};
                inhabitants[1] = new int[] { 4, 1 };
                inhabitants[2] = new int[] { 3, 1 };
                inhabitants[3] = new int[] { 2, 1 };
            }

            Solution sl = new Solution();
            sl.FindJudge(4,inhabitants);
        }
    }
}
