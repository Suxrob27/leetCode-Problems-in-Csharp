using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _169.Majority_Element
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            var occurences = new List<int>();
            int totalOccurance = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (occurences.Contains(nums[i]))
                {
                    continue;
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        totalOccurance++;
                    }
                    if (totalOccurance > nums.Length / 2)
                    {
                        return nums[i];
                    }
                }
                occurences.Add(nums[i]);
            }

            return nums.First();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.MajorityElement(new int[] { 2,2,2,1,1,1,3,3,3});
        }
    }
}
