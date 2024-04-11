using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _136.Single_Number
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            var asd = nums.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).First();
            return nums.GroupBy(x => x).Where(g => g.Count() == 1).Select(x => x.Key).First();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution sl = new Solution();
            sl.SingleNumber(new int[] {1,3,1,4,4,5,5});
        }
    }
}
