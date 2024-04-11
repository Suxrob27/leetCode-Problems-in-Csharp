using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _71.Simplify_Path
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            Stack<string> values = new Stack<string>();
            string[] strings = path.Split('/');

            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] == "..")
                {
                    values.Pop();
                }
                else if (strings[i] == "." || strings[i] == "")
                {
                    continue;
                }
                else
                {
                    values.Push(strings[i]);
                }
            }
            string cur = "";
            for (int i = 0; i < values.Count; i++)
            {
                cur += values.Pop();
            }
            return "/" + cur;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Solution  solution = new Solution();
            solution.SimplifyPath("/home//foo/");
        }
    }
}
