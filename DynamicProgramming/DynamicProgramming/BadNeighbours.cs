using System.Collections.Generic;
using System.Linq;

namespace DynamicProgramming
{
    public static class BadNeighbours
    {
        public static int MaxDonations(this List<int> donations)
        {
            int maxDonationsIncludingFirst = MaxDonationsLinear(donations.TakeWhile((i, index) => index+1 != donations.Count).ToList());
            int maxDonationsIncludingLast = MaxDonationsLinear(donations.SkipWhile((i, index) => index  == 0).ToList());
            return maxDonationsIncludingFirst > maxDonationsIncludingLast ? maxDonationsIncludingFirst:maxDonationsIncludingLast;
        }

        private static int MaxDonationsLinear(List<int> donations)
        {
            var maxDonationList = new List<int>();
            for (int i = 0; i < donations.Count; i++)
            {
                maxDonationList.Add(donations[i]);
                if(i==1 && maxDonationList[0] > maxDonationList[1])  maxDonationList[1] = maxDonationList[0];
                else if(i>1)
                {
                    int nMinus2 = i - 2 < 0 ? 0 : maxDonationList[i - 2] + donations[i];
                    int nMinus3 = i - 3 < 0 ? 0 : maxDonationList[i - 3] + donations[i];
                    maxDonationList[i] = nMinus2 > nMinus3 ? nMinus2 : nMinus3;
                }
            }
            return maxDonationList.Last();
        }
    }
}