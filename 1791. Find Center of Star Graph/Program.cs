using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1791.Find_Center_of_Star_Graph
{
    public class Solution
    {
        public int FindCenter(int[][] edges)
        {
          
            
                // Get the nodes from the first edge
                int node1 = edges[0][0];
                int node2 = edges[0][1];

                // Check if either of these nodes is the center by checking the second edge
                if (node1 == edges[1][0] || node1 == edges[1][1])
                {
                    return node1;
                }
                return node2;
            }
    }
    public  class Program
    {
        static void Main(string[] args)
        {
            int[][] edges = new int[3][];
            edges[0] = new int[] {1,2 };
            edges[1] = new int[] { 2, 3 };
            edges[2] = new int[] { 4, 2 };

            Solution solution = new Solution(); 
            solution.FindCenter(edges); 

        }
    }
}
