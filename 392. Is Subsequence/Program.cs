using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _392.Is_Subsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            var secondPointer = 0;
            if (s.Length == 0)
            {
                return true;
            }
            foreach (var t1 in t.Where(t1 => t1.Equals(s[secondPointer])))
            {
                secondPointer++;
                if (secondPointer.Equals(s.Length))
                {
                    return true;
                }
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.IsSubsequence("asb","asabiy");
        }
    }
}
