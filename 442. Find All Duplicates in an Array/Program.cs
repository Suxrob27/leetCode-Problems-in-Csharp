using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _442.Find_All_Duplicates_in_an_Array
{

    public class Solution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> result = new List<int>();

            foreach (int num in nums)
            {
                int index = System.Math.Abs(num) - 1;
                if (nums[index] < 0)
                {
                    result.Add(index + 1);
                }
                else
                {
                    nums[index] = -nums[index];
                }
            }

            foreach (int num in nums)
            {
                int index = System.Math.Abs(num) - 1;
                nums[index] = -nums[index];
            }

            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindDuplicates(new int[] { 4,5,1,1,2,3,4,5,6,6,7,8,9});
        }
    }
}
