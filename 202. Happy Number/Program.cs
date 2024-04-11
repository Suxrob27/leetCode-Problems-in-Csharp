using System;
public class Solution
{
    public bool IsHappy(int n)
    {
        var numbers = new HashSet<int>();
        while(n > 1 && numbers.Add(n))
        {
            var sum = 0;
            while(n > 0)
            {
                sum += (n % 10) * (n % 10);
                n /= 10;    
            }
            n = sum;    
        }
        return n == 1;
    }
}
class Program
{
    static void Main(string[] args)
    {
       
    }

}