using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34.Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int first = -1;
            int last = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    first = i;
                    while (i < nums.Length && nums[i] == target)
                    {
                        i++;
                    }
                    last = i - 1;
                    return new int[] { first, last };
                }
            }
            return new int[] { first, last };
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] ints = { 1, 2, 3, 4, 5,   6, 7, 8, 8,9 };    
            Hashtable hashtable = new Hashtable();  
            hashtable.
            solution.SearchRange(ints,8);
        }
    }
}
