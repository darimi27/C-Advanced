using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
class MatrixShuffling
{
    static void Main()
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        var matrix = new string[m, n];
        string temp;
        //Fill the matrix
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Console.ReadLine();
            }
        }
        var command = Console.ReadLine();
        var listOfCommands = new List<string>();
        while (command != "END")
        {
            string pattern = @"(swap( \d+){4})";
            Regex regex = new Regex(pattern);
            bool containsValidDate = regex.IsMatch(command);
            if (containsValidDate == true)
            {
                listOfCommands = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                int x1 = int.Parse(listOfCommands[1]);
                int y1 = int.Parse(listOfCommands[2]);
                int x2 = int.Parse(listOfCommands[3]);
                int y2 = int.Parse(listOfCommands[4]);
                if (x1 < m && y1 < n && x2 < m && y2 < n && x1 >= 0 && x2 >= 0 && y1 >= 0 && y2 >= 0)
                {
                    temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    listOfCommands.Clear();
                    command = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
                command = Console.ReadLine();
            }
        }
    }
}

