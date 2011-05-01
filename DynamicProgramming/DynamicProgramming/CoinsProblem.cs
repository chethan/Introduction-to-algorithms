using System.Collections.Generic;

namespace DynamicProgramming
{
    public class CoinsProblem
    {
        private readonly int[] denominations;
        private readonly IDictionary<int, int> minimuSums;

        public CoinsProblem(params int[] denominations)
        {
            this.denominations = denominations;
            minimuSums=new Dictionary<int, int> {{0, 0}};
        }

        // Sn =  min {Sn-1,Sn-3,Sn-5} + 1 for 1,3,5 denominations
        public int MinimumNumberOfCoins(int totalAmount)
        {
            if (minimuSums.ContainsKey(totalAmount)) return minimuSums[totalAmount];
            for (var i = 1; i <= totalAmount; i++)
            {
                minimuSums[i]= int.MaxValue;
                foreach (var denom in denominations)
                {
                    if (!minimuSums.ContainsKey(i-denom)) break;
                    var temp = minimuSums[i - denom] + 1;
                    if (temp < minimuSums[i]) minimuSums[i] = temp;
                }
            }
            return minimuSums[totalAmount];
        }
    }
}
