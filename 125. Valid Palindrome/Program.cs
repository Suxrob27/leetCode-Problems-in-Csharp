using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125.Valid_Palindrome
{

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
        

            for (int i = 0, j = s.Length - 1; j > i;)
            {
                if (!char.IsLetterOrDigit(s[i]))
                {
                    i++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[j]))
                {
                    j--;
                    continue;
                }

                if (char.ToLower(s[i++]) != char.ToLower(s[j--]))
                {
                    Console.WriteLine("false");
                    return false;
                    
                }
            }
            Console.WriteLine("true");
            return true;

        }


        public bool IsPalindrome2(string s)
        {
            string stringer ="";
            for (int i = s.Length; i >= s.Length ; i--)
            {
                stringer += s[i];
            }
            if(stringer == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.IsPalindrome("A man, a plan, a canal: Panama");
        }
    }
}
