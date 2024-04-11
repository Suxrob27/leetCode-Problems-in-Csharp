using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _594.Longest_Harmonious_Subsequence
{
    public class Solution
    {
        public int FindLHS(int[] nums)
        {
            int ans = 0;
            int r = 0, l = 0, n = nums.Length;

            Array.Sort(nums);
            while (r < n)
            {
                if (nums[r] == nums[l] || nums[r] - nums[l] == 1)
                {
                    r++;
                }
                else
                {
                    l++;
                }
                ans = nums[r - 1] - nums[l] == 1 ? Math.Max(ans, r - l) : ans;
            }
            Console.WriteLine(ans);
            return ans;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
         Solution solution = new Solution();
            solution.FindLHS(new int[] {1,5,3,4,4,5,4,3,3,1,2,3 });
         
        }
    }
}
