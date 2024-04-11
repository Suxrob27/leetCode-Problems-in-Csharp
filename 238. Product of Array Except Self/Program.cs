using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _238.Product_of_Array_Except_Self
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] answer = new int[nums.Length];
            int left = 1,  right = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                answer[i] = right;
                right *= nums[i];
            }
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                answer[i] *= left;
                left *= nums[i];
            }
            return answer;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new int[] { 1, 2, 3, 4 };
            solution.ProductExceptSelf(nums);       
            }
    }
}
