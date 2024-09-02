using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1971.Find_if_Path_Exists_in_Graph_
{
    public class Solution
    {
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            var hash = new Dictionary<int, List<int>>();

            foreach (var edge in edges)
            {
                if (!hash.ContainsKey(edge[0])) hash[edge[0]] = new List<int>();
                if (!hash.ContainsKey(edge[1])) hash[edge[1]] = new List<int>();
                hash[edge[0]].Add(edge[1]);
                hash[edge[1]].Add(edge[0]);
            }

            var q = new Queue<int>();
            q.Enqueue(source);
            var visit = new HashSet<int>();

            while (q.Count > 0)
            {
                var cur = q.Dequeue();
                if (cur == destination) return true;

                foreach (var node in hash[cur])
                {
                    if (!visit.Contains(node))
                    {
                        q.Enqueue(node);
                        visit.Add(node);
                    }
                }
            }
            return false;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
