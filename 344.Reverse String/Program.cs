using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _344.Reverse_String
{
    public class Solution
    {
        public void ReverseString(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left < right)
            {
                char temp = s[left];
                s[left] = s[right];
                s[right] = temp;
                left++;
                right--;
            }
            foreach (char c in s) 
            {
                Console.WriteLine(c);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            char[] item1 = new char[] { 's', 'u', 'x', 'r', 'o', 'b' };
            solution.ReverseString(item1);
            
        }
    }
}
