using System;
using System.Collections.Generic;
class SequenceInMatrix
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        var matrix = new string[m, n];
        int count = 1;
        int bestCount = 0;
        string bestRow = String.Empty;
        var listOfCounts = new List<int>();
        //Fill the matrix
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
        //Check the Row
        for (int i = 0; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                if (matrix[i, j - 1].Equals(matrix[i, j]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestRow = matrix[i, j-1];
                }
            }
        }
        //Check the column
        for (int i = 0; i < m; i++)
        {
            for (int j = 1; j < n ; j++)
            {
                if (matrix[j-1,i].Equals(matrix[j,i]))
                {
                    count++;
                }
                else
                {
                    count = 1;
                    break;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestRow = matrix[j, i];
                }
            }
        }
        //Check the diagonal
   
        for (int j = 1; j <m; j++)
        {
            if (matrix[j-1,j-1].Equals(matrix[j,j]))
            {
                count++;
            }
            else
            {
                count = 1;
            }
            if (count > bestCount)
            {
                bestCount = count;
                bestRow = matrix[j,j];
            }
        }
        
        //Print the result
        for (int i = 0; i < bestCount - 1; i++)
        {
            Console.Write(bestRow + ", ");
        }
        Console.Write(bestRow);
        Console.WriteLine();

    }
}

