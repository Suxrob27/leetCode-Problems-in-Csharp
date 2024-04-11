using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _88.Merge_Sorted_Array
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            Array.Copy(nums1, nums2, n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
