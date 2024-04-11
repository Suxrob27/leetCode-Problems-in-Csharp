using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383.Ransom_Note
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int size = 0;
            Dictionary<char, int> letters = new Dictionary<char, int>();
            foreach (char letter in magazine)
            {
                if (letters.ContainsKey(letter))
                {
                    letters[letter] += 1;
                }
                else
                {
                    letters[letter] = 1;
                }
            }


            foreach (char c in ransomNote) 
            {
              if(letters.ContainsKey(c) && letters[c] > 0)
                { 
                    letters[c] -= 1;
                }
              else
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
            solution.CanConstruct("aab", "aabbbc");
        }
    }
}
