using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Container_With_Most_Water
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            int res = 0;
            int left = 0;  
            int right = height.Length - 1;  

            while (left < right)
            {
                int mini = Math.Min(height[left], height[right]);
                int area = (left - right) * Math.Min(height[left], height[right]);

               res = Math.Max(res, area);

                if (height[left] < height[right])
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            Console.WriteLine(res);
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.MaxArea(new int[] { 1, 4, 8, 2, 4, 6, 8, 3, 5, 8, 10 });
        }
    }
}
