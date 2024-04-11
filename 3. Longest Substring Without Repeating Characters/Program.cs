using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Longest_Substring_Without_Repeating_Characters
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            HashSet<char> charSet = new HashSet<char>();

            int l = 0;
            int res = 0;

            for (int r = 0; r < s.Length; r++)
            {
                while (charSet.Contains(s[r]))
                {
                    charSet.Remove(s[l]);
                    l++;
                }
                charSet.Add(s[r]);
                res = Math.Max(res, r - l + 1);
            }
            return res;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcabcbb";
            Solution solution = new Solution();
            solution.LengthOfLongestSubstring(str);
        }
    }
}
