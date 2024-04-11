using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
public class Solution
{
    public int RomanToInt(string s)
    {
        var roman = new Dictionary<char, int>
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
        int result = 0;
        for (int i = 0; i < s.Length ; i++)
        {
            if (i + 1 < s.Length && roman[s[i]] < roman[s[i + 1]])
            {
                result -= roman[s[i]];
            }
            else
            { 
              result += roman[s[i]];        
            }
        }
        return result;
    }

}


