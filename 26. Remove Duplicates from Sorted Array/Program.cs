using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26.Remove_Duplicates_from_Sorted_Array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int k = 1;
            int previouse = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
                if (nums[i] != previouse)
                {
                    nums[k] = nums[i];
                    k++;
                }
                previouse = nums[i];
            }
            return k;
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            sl.RemoveDuplicates(new int[] { 0,0,1,1,1,2,3,3,3,4,4,4,5,5,6,6});
        }
    }
}
