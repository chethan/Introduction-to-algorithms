using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var coinsProblem = new CoinsProblem(1,3,5);
            Console.WriteLine(coinsProblem.MinimumNumberOfCoins(11));
            Console.WriteLine(new List<int> { 1, 3, 5, 2, 7, 0, 11 }.LongestIncreasingSubsequence());
            Console.WriteLine(new List<int> { 1, 3, 5, 2, 7, 0, 11 }.TogglingSubsequence());

            Console.ReadLine();
        }
    }
}
