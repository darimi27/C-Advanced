using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
class StringMatrix
{
    static void Main()
    {
        var command = Console.ReadLine();
        var input = Console.ReadLine();
        var matrix = new List<char[]>();
        //Fill the list
        while (input != "END")
        {
            matrix.Add(input.ToCharArray());
            input = Console.ReadLine();
        }
        //Calculate the MaxLengthRow
        int maxLength = int.MinValue;
        for (int i = 1; i < matrix.Count; i++)
        {
            int temp = Math.Max(matrix[i - 1].Length, matrix[i].Length);
            if (temp > maxLength)
            {
                maxLength = temp;
            }
        }
        string pattern = @"\d+";
        int rotate = int.Parse(Regex.Match(command, pattern).ToString());
        int result = rotate % 360;
        char[,] matrixConverted = Convert(matrix, maxLength);
        switch (result)
        {
            case 0:
                PrintMatrix(matrix);
                break;
            case 90:
                int row = maxLength;
                int col = matrix.Count;
                char[,] output = new char[row, col];
                int rowM = col - 1;
                int colM = 0;
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        output[i, j] = matrixConverted[rowM, colM];
                        rowM--;
                    }
                    rowM = col - 1;
                    colM++;
                }
                Print(output, row, col);
                break;
            case 180:
                int row1 = matrix.Count;
                int col1 = maxLength;
                rowM = row1 - 1;
                colM = col1 - 1;
                char[,] output1 = new char[row1, col1];
                for (int i = 0; i < row1; i++)
                {
                    for (int j = 0; j < col1; j++)
                    {
                        output1[i, j] = matrixConverted[rowM, colM];
                        colM--;
                    }
                    colM = col1 - 1;
                    rowM--;
                }
                Print(output1, row1, col1);
                break;
            case 270:
                int row2 = maxLength;
                int col2 = matrix.Count;
                int rowStart = 0;
                int colStart = maxLength - 1;
                char[,] output2 = new char[row2, col2];
                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < col2; j++)
                    {
                        output2[i, j] = matrixConverted[rowStart, colStart];
                        rowStart++;
                    }
                    rowStart = 0;
                    colStart--;
                }
                Print(output2, row2, col2);
                break;
        }
    }
    public static void PrintMatrix(List<char[]> matrix)
    {
        foreach (var arr in matrix)
        {
            foreach (var ch in arr)
            {
                Console.Write(ch);
            }
            Console.WriteLine();
        }
    }
    public static void Print(char[,] output, int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Console.Write(output[i, j]);

            }
            Console.WriteLine();
        }
    }
    public static char[,] Convert(List<char[]> matrix, int maxLength)
    {
        char[,] matrixConvereted = new char[matrix.Count, maxLength];
        for (int i = 0; i < matrix.Count; i++)
        {
            for (int j = 0; j < maxLength; j++)
            {
                if (j > matrix[i].Length - 1)
                {
                    matrixConvereted[i, j] = ' ';
                }
                else
                {
                    matrixConvereted[i, j] = matrix[i][j];
                }
            }
        }
        return matrixConvereted;
    }
}

