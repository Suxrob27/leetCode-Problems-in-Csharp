using System;
public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
       HashSet<int> window = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
           if(window.Count > k)
            {
                window.Remove(i - k);
            }

            if (window.Contains(nums[i]))
            {
                return true;
            }
            window.Add(nums[i]);    
        }
        return false;   
    }
}

class Program
{
    public void Main(string[] args)
    {
        Solution solution = new Solution();
        //solution.ContainsNearbyDuplicate(fill overloads);
    }
}