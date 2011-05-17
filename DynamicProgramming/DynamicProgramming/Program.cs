using System;
using System.Collections.Generic;

namespace DynamicProgramming
{
    public class Program
    {
        public static void Main(string[] args)
        {
//            Console.WriteLine(new TriangleNumbers(new[,]{{3,0,0,0},{7,4,0,0},{2,4,6,0},{8,5,9,3}}).MaximumSum());
//            Console.WriteLine(new CoinsProblem(1, 3, 5).MinimumNumberOfCoins(11));
//            Console.WriteLine(new List<int> {1, 3, 5, 2, 7, 0, 11}.LongestIncreasingSubsequence());
//            Console.WriteLine(new List<int> {1, 3, 5, 2, 7, 0, 11}.TogglingSubsequence());
//            Console.WriteLine(new List<int> {10, 3, 2, 5, 7, 8}.MaxDonations());
//            Console.WriteLine("BDCABA".ToList().LeastCommonSubsequence(new List<char>("ABCBDAB")));
            Console.WriteLine(new List<int> {802,421,143,-302,137,316,150,-611,-466,-42,-195,-295}.GetSubSetsForSum(0));
            Console.ReadLine();
        }


    }
}