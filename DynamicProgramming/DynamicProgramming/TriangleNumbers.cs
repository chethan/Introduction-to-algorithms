using System;
using System.Text;

namespace DynamicProgramming
{
    public class TriangleNumbers
    {
        private readonly int[,] triangleNumbers;

        public TriangleNumbers(int[,] numbers)
        {
            triangleNumbers = numbers;
        }

        public long MaximumSum()
        {
            var lenght = (int) Math.Sqrt(triangleNumbers.Length);
            var maximumSums = new int[lenght, lenght];
            var maximumSumsPerLevel = new int[lenght];
            for (int column = 0; column < lenght; column++)
            {
                maximumSums[0, column] = triangleNumbers[0, column];
            }
            
            for (int level = 1; level < lenght; level++)
            {
                maximumSumsPerLevel[level] = 0;
                for (int colum = 0; colum < lenght; colum++)
                {
                    int sum1 = colum == 0 ? 0 : maximumSums[level - 1, colum - 1]; 
                    int sum2 = maximumSums[level - 1, colum];
                    maximumSums[level, colum] = Math.Max(sum1, sum2) + triangleNumbers[level,colum];
                    maximumSumsPerLevel[level] = Math.Max(maximumSumsPerLevel[level], maximumSums[level, colum]);
                }
            }
            return maximumSumsPerLevel[lenght - 1];
        }
    }
}