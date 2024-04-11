using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _290.Word_Pattern
{
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            string[] sChar = s.Split(' ');

            if(sChar.Length != pattern.Length)
            {
                return false;
            }

            for (int i = 0; i < pattern.Length; i++)
            {
                var patterchnar = pattern[i];

                if(dict.TryGetValue(patterchnar, out var currentPair))
                {
                    if(currentPair != sChar[i])
                    {
                        return false;   
                    }
                    continue;
                }


                if (dict.ContainsValue(sChar[i]))
                {
                    return false;
                }

              
               dict.Add(patterchnar, sChar[i]);
       
            }
            Console.WriteLine("true");
            return true;    
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.WordPattern("aab", "ad ad bad");
        }
    }
}
