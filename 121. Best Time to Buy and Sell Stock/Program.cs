public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int minPrice = int.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
            {
                minPrice = prices[i];
            }
             
            int profit = prices[i] - minPrice;
            if (profit > maxProfit)
            {
                maxProfit = profit;
            }

        }
        Console.WriteLine(maxProfit);
        return maxProfit;

    }
} 
class Program
{
    static void Main(string[] args)
    {
        int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
        Solution sl = new Solution();   
        sl.MaxProfit(prices);   
    }
}