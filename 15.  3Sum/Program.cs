using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _15._3Sum
{
    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
          List<IList<int>> list = new List<IList<int>>();

            Array.Sort(nums);   

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (i >= 0 && nums[i] == nums[i + 1])
                {
                    continue;
                }
                int left = 0;
                int right = nums.Length - 1;  

                while (left < right) 
                {
                    int sum = nums[i] + nums[left] + nums[right]; 
                    if (nums[i] + nums[left] > 0)
                    {
                        break;
                    }

                    if(sum == 0)
                    {
                        List<int> temp = new List<int>();
                        temp.Add(nums[i]);  
                        temp.Add(left);
                        temp.Add(right);
                    }

                    if(sum < 0)
                    {
                        left++;
                        
                    }
                    else 
                    {
                        right--;
                    }
                }    

            }
            return list;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            IList<IList<int>> list = new List<IList<int>> { new int[] { -1, 0, 1, 2, -1, -4 } };
   
            int[] flatArray = list.SelectMany(innerList => innerList).ToArray();
            sl.ThreeSum(flatArray); 
        }
    }
}
