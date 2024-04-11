using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _133.Clone_Graph
{
    public class Node
    {
        public int val;
        public IList<Node> neighbors;

        public Node()
        {
            val = 0;
            neighbors = new List<Node>();
        }

        public Node(int _val)
        {
            val = _val;
            neighbors = new List<Node>();
        }

        public Node(int _val, List<Node> _neighbors)
        {
            val = _val;
            neighbors = _neighbors;
        }
    }


public class Solution
    {
        public Node CloneGraph(Node node)
        {
            if (node is null) return null;
            var queue = new Queue<Node>();
            var visited = new Dictionary<Node, (Node, bool)>();
            queue.Enqueue(node);
            visited.Add(node, (new Node(node.val), false));

            while (queue.Any())
            {
                var current = queue.Dequeue();
                var copy = visited[current].Item1;

                foreach (var neighbor in current.neighbors)
                {
                    if (!visited.ContainsKey(neighbor))
                        visited.Add(neighbor, (new Node(neighbor.val), false));

                    copy.neighbors.Add(visited[neighbor].Item1);

                    if (!visited[neighbor].Item2 && !queue.Contains(neighbor))
                        queue.Enqueue(neighbor);
                }

                visited[current] = (visited[current].Item1, true);
            }

            return visited[node].Item1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Node> nodes = new List<Node>()
            {
              new Node { val = 1}
              , new Node { val = 2} 
              , new Node { val = 3} 
              , new Node { val = 4} 
            };
            Node node = new Node(0,nodes);

            Solution sl = new Solution();
            sl.CloneGraph(node);
        }
    }
}
