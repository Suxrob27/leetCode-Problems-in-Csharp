using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500.Keyboard_Row
{
    public class Solution
    {
        public string[] FindWords(string[] words)
        {
            HashSet<char> row1 = new HashSet<char>("qwertyuiop");
            HashSet<char> row2 = new HashSet<char>("asdfghjkl");
            HashSet<char> row3 = new HashSet<char>("zxcvbnm");

            return words.Where(x =>
            x.All(c => row1.Contains(char.ToLowerInvariant(c))) ||
            x.All(c => row2.Contains(char.ToLowerInvariant(c))) ||
            x.All(c => row3.Contains(char.ToLowerInvariant(c)))
            ).ToArray();
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
