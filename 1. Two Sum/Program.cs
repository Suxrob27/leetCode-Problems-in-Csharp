using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.ContainsKey(target - nums[i]))
                {
                    Console.WriteLine($"{seen[target - nums[i]]},{i}");
                    return new int[] { seen[target - nums[i]], i };
                }
                if (!seen.ContainsKey(nums[i]))
                {
                    seen.Add(nums[i], i);
                }
            }
            return null;

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.TwoSum(new int[] {1,2,3,4,4,5,6},8);
        }
    }
}
