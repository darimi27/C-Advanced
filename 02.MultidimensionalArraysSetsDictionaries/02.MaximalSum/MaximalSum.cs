using System;
using System.Linq;
internal class MaximalSum
{
    static void Main()
    {
        var size = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
        int n = size[0];
        int m = size[1];
        var matrix = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = input[j];
            }
        }
        Console.WriteLine();
        //Find the maximal sum platform of size 3x3
        int sum = int.MinValue;
        int bestSum = 0;
        int bestRow = 0;
        int bestCol = 0;
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = 0; j < m - 2; j++)
            {
                sum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2]
                + matrix[i + 1, j] + matrix[i + 1, j + 1] + matrix[i + 1, j + 2]
                + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = i;
                    bestCol = j;
                }

            }

        }
        //Print the result
        Console.WriteLine("Sum = {0}", bestSum);
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
    }
}

