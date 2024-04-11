using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53.Maximum_Subarray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int maxEnding = nums[0];
            int max = nums[0];

            for (int i = 1; nums.Length > i; i++)
            {
                maxEnding = Math.Max(nums[i], maxEnding + nums[i]);
                max = Math.Max(maxEnding, max);
            }
            return max;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] maxsub = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4}; 
            Solution solution = new Solution();
            solution.MaxSubArray(maxsub);
        }
    }
}
