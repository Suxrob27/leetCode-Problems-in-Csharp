using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _110.Balanced_Binary_Tree
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
        public bool IsBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int leftHeight = GetHeight(root.left);
            int rightHeight = GetHeight(root.right);

            if (Math.Abs(leftHeight - rightHeight) > 1)
                return false;
            bool lolo = IsBalanced(root.left) && IsBalanced(root.right);
            Console.WriteLine(lolo);
            return IsBalanced(root.left) && IsBalanced(root.right);
        }


        private int GetHeight(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftHeight = GetHeight(node.left);
            int rightHeight = GetHeight(node.right);

            return Math.Max(leftHeight, rightHeight) + 1;
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
            solution.IsBalanced(treeNode);
        }
    }
}
