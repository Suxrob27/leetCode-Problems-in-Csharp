using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _94.Binary_Tree_Inorder_Traversal
{
   
 public class TreeNode {
     public int val;
     public TreeNode left;
     public TreeNode right;
     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
         this.val = val;
         this.left = left;
         this.right = right;
     }
 }
 
    public class Solution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {

            List<int> output = new List<int>();

            Traverse(root);

            return output;

            void Traverse(TreeNode current)
            {
                if (current == null) return;

                Traverse(current.left);

                output.Add(current.val);

                Traverse(current.right);

                return;
            }
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
            solution.InorderTraversal(treeNode);
        }
    }
}
