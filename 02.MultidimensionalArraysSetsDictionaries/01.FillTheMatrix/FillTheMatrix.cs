using System;
class FillTheMatrix
{
    static void Main()
    {
        int[,] firstMatrix = new int[4, 4];
        int[,] secondMatrix = new int[4, 4];
        int count = 1;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {

                firstMatrix[j, i] = count;
                count++;
            }
        }
        count = 1;
        for (int i = 0; i < 4; i++)
        {
            if (i == 0 || i % 2 == 0)
            {
                for (int j = 0; j < 4; j++)
                {
                    secondMatrix[j, i] = count;
                    count++;
                }
            }
            else
            {
                for (int j = 3; j > -1; j--)
                {
                    secondMatrix[j, i] = count;
                    count++;
                }
            }

        }
        PrintMatrix(firstMatrix);
        Console.WriteLine();
        PrintMatrix(secondMatrix);
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

