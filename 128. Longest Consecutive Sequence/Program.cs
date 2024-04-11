using System;

public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0)
        {
            return -1;
        }
        HashSet<int> set = new HashSet<int>(nums);
        int answer = 1;
        foreach (int hash in set)
        {
            int count = 1;
            while (set.Contains(hash + count))
            {
                count++;
            }
            answer = Math.Max(answer, hash);


        }
        return answer;
    }
}
class Program
{
    static void Main(string[] args)
    {
      Solution solution = new Solution();
      solution.LongestConsecutive(new int[] {1,2,3,4,100,200 });
    }
}