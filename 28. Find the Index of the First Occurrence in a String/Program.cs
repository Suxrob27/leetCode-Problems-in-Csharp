using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Find_the_Index_of_the_First_Occurrence_in_a_String
{
    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            int first = -1;
            int last = -1;

            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                for (int j = 0; j < needle.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }

                    if (j == needle.Length - 1)
                    {
                        if (first == -1)
                        {
                            first = i;
                        }

                        last = i;
                    }
                }
            }

            return first;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.StrStr("human","um");
        }
    }
}
