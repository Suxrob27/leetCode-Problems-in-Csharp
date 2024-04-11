using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _506.Relative_Ranks
{
    public class Solution
    {
        public string[] FindRelativeRanks(int[] score)
        {
            string[] length = new string[score.Length];
            int[] sortedScore = score.ToArray();    
            Array.Sort(sortedScore);        
          
            Dictionary<int, string> medals = new Dictionary<int, string>();
            if (sortedScore.Length>0)
               medals.Add(sortedScore[sortedScore.Length-1],"Gold Medal");
            if (sortedScore.Length > 1)
                medals.Add(sortedScore[sortedScore.Length-2],"Silver Medal");
            if (sortedScore.Length > 2)
                medals.Add(sortedScore[sortedScore.Length - 3], "Bronze Medal");
            for(int i =0;i< Math.Max(0, length.Length -3); i++)
            {
                medals.Add(sortedScore[i],(length.Length -i).ToString());
            }
            for (int i = 0; i < score.Length; i++)
            {
                length[i] = medals[score[i]];
            }
            return length;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            solution.FindRelativeRanks(new int[] { 1,2,3,4,5,6,7}); 
        }
    }
}
