using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _209.Minimum_Size_Subarray_Sum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int l = 0, total = 0;
            int res = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];

                while (total > target)
                {
                    res = Math.Min(i - l + 1, res);
                    total -= nums[l];
                    l++;
                }
            }
            if (res == int.MaxValue)
            {
                return -1;
            }
            else
            {
                return res;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
