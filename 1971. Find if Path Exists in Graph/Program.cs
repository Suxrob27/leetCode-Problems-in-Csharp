using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1971.Find_if_Path_Exists_in_Graph
{
    public class Solution
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            List<int>[] path = new List<int>[n];
            bool[] visisted = new bool[n];
             for(int i = 0; i < n;i++)
             {
                path[i] = new List<int>();  
             }

            foreach (var edge in edges)
            {
                var a = edge[0];
                var b = edge[1];
                path[a].Add(b);
                path[b].Add(a); 
            }

            bool found = false;
            Queue<int> bfs = new Queue<int>();
            bfs.Enqueue(source);
            while(bfs.Count > 0)
            {
                int top = bfs.Peek();
                visisted[top] = true;   
                bfs.Dequeue();
                if (top == destination)
                {
                    return true;
                }
                foreach (var paths in path[top])
                {
                    if (!visisted[paths])
                    {
                        bfs.Enqueue(paths);
                    }
                }
            }
            return found;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[][] lt = new int[4][];
            {
                lt[0] = new int[] { 0, 1 };
                lt[1] = new int[] { 3, 2 };
                lt[2] = new int[] { 3, 1 };
                lt[3] = new int[] { 2, 1 };
            }
            sl.ValidPath(4,lt,4,5);

        }
    }
}
