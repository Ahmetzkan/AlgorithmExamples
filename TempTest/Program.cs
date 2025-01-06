using System;

public class Solution
{
    public static int ClimbStairs(int n)
    {
        int[] dp = new int[n + 1];
        dp[0] = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n; j++)
            {
                dp[j] += dp[j - i];
            }
        }

        return dp[n];
    }

    public static void Main(string[] args)
    {
        int result = ClimbStairs(10);
        Console.WriteLine("Result: " + result);
        Console.ReadLine();
    }
}
