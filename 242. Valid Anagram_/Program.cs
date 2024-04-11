using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242.Valid_Anagram
{
    public class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            // Assuming ASCII characters; adjust size for Unicode if necessary
            int[] letterCounts = new int[256];

            // Count characters for s and subtract for t in the same pass
            for (int i = 0; i < s.Length; i++)
            {
                letterCounts[s[i]]++;
                letterCounts[t[i]]--;
            }

            // Check if any character count is not zero (meaning s and t are not anagrams)
            for (int i = 0; i < letterCounts.Length; i++)
            {
                if (letterCounts[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
    class Program
    {
        static void Main(string[] args) 
        {
            Solution solution = new Solution();
            solution.IsAnagram("mana" , "nama");
        }
    }
}
