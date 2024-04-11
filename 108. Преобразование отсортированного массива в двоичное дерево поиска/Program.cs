using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _108.Преобразование_отсортированного_массива_в_двоичное_дерево_поиска
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
        public TreeNode SortedArrayToBST(int[] nums)
        {
            double total = nums.Count();
            if (total == 0) return null;
            int mid = (int)Math.Floor(total / 2);
            int[] left = new int[mid];
            Array.Copy(nums, left, mid);
            int[] right = new int[nums.Length - mid - 1];
            Array.Copy(nums, mid + 1, right, 0, nums.Length - mid - 1);
            return new TreeNode(nums[mid], SortedArrayToBST(left), SortedArrayToBST(right));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -10, -3, 0, 5, 9 };
            Solution sl = new Solution();
            sl.SortedArrayToBST(nums);
        }
    }
}
