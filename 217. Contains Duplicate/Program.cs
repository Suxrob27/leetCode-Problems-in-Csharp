using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _217.Contains_Duplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hs = new HashSet<int>(nums);
            return nums.Length != hs.Count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] {1,1,2,3,4,1,4,3,4};
            Solution solution = new Solution(); 
            solution.ContainsDuplicate(nums);   
        }
    }
}
