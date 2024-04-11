public class Solution
{
    public int DeleteGreatestValue(int[][] grid)
    {
        int sum = 0;
        foreach (var row in grid)
        {
            Array.Sort(row);
        }
        for (int i = 0; i < grid[0].Length; i++)
        {
            int max = grid[0][i];
            for (int j = 0; j < grid.Length; j++)
            {
                if (max < grid[j][i])
                    max = grid[j][i];
            }
            sum += max;
        }
        return sum;
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[][] arr = new int[2][];
        arr[0] = new int[] { 1,2,3};
        arr[1] = new int[] { 6,5,4}; 
        solution.DeleteGreatestValue(arr);  
    }
}