
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
      var angrams = new Dictionary<string, List<string>>();
      IList<IList<string>> ans = new List<IList<string>>();

      for(int i = 0; i < strs.Length; i++)
      {
            var temp = strs[i].ToCharArray();

            Array.Sort(temp);

            var current = new string(temp);

            if(angrams.ContainsKey(current))
            {
                angrams[current].Add(strs[i]);
            }
            else
            {
                angrams.Add(current , new List<string> { strs[i] });
                ans.Add(angrams[current]);      
            }

      }
      return ans;   
    }
}

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        solution.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
    }
}

