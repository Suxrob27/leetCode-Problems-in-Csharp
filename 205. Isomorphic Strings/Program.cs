using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _205.Isomorphic_Strings
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
           if(s.Length != t.Length)
            {
                return false;   
            }
            
            Dictionary<char, char> dict = new Dictionary<char, char>();
            HashSet<char> set = new HashSet<char>();

            for (int i = 0; i < s.Length; i++)
            {
                var schar = s[i];
                var tchar = t[i];
                if (!dict.ContainsKey(schar))
                {
                    if(set.Contains(tchar))
                    {
                        return false;
                    }
                    dict.Add(schar, tchar);
                    set.Add(tchar);
                }
                else 
                {
                 if(tchar != dict[schar])
                    {
                        return false;
                    }
                }    

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
            solution.IsIsomorphic("ehh","arr");
        }
    }
}
