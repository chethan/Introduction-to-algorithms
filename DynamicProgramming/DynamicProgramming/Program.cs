using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(new CoinsProblem(1,3,5).MinimumNumberOfCoins(11));
            Console.WriteLine(new List<int> { 1, 3, 5, 2, 7, 0, 11 }.LongestIncreasingSubsequence());
            Console.WriteLine(new List<int> { 1, 3, 5, 2, 7, 0, 11 }.TogglingSubsequence());
            Console.WriteLine(new List<int> {10,3,2,5,7,8 }.MaxDonations());
            Console.ReadLine();
        }
    }
}
