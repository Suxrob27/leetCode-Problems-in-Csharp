using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _104.Maximum_Depth_of_Binary_Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode treeNode = new TreeNode()
            {
                val = 2,
                left = new TreeNode(1),
                right = new TreeNode(6),
            };
            Solution solution = new Solution();
            solution.MaxDepth(treeNode);
        }
    }
}
