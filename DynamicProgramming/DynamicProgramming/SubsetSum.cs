using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    public static class SubsetSum
    {
        public static List<int> GetSubSetsForSum(this List<int> list,int sum)
        {
            int positiveSum = list.Sum(i => i>0?i:0);
            int negativeSum = list.Sum(i => i>0?0:i);
            var subsetSums = new bool[list.Count,positiveSum-negativeSum+1];
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j <=(positiveSum-negativeSum); j++)
                {
                    subsetSums[i, j] = false; 
                    if (list[i] == j+negativeSum) subsetSums[i, j] = true;
                    else if(i>0)
                    {
                        if (subsetSums[i - 1, j] || (j - list[i] > 0 && j - list[i] <= positiveSum-negativeSum && subsetSums[i - 1, j - list[i]]))
                            subsetSums[i, j] = true;
                    }
                }
            }

            bool isSumPossible = sum >= negativeSum && sum <= positiveSum && subsetSums[list.Count - 1, sum-negativeSum];
            return GenerateSubset(list, sum, subsetSums, negativeSum, isSumPossible);
        }

        private static List<int> GenerateSubset(IList<int> list, int sum, bool[,] subsetSums, int negativeSum, bool isSumPossible)
        {
            var subset = new List<int>();
            if (!isSumPossible) return subset;
            for (int i = list.Count - 1, j = sum - negativeSum; i >= 0; i--)
            {
                if (subsetSums[i, j] && (i==0 || !subsetSums[i-1, j]))
                {
                    subset.Add(list[i]);
                    j = j - list[i];
                }
            }
            return subset;
        }
    }
}