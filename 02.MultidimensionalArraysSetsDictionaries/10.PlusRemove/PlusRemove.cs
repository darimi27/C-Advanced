using System;
using System.Collections.Generic;
class PlusRemove
{
    static void Main()
    {
        var input = Console.ReadLine();
        var text = new List<char[]>();
        var output = new List<char[]>();
        while (input != "END")
        {
            text.Add(input.ToLower().ToCharArray());
            output.Add(input.ToLower().ToCharArray());
            input = Console.ReadLine();
        }
        for (int i = 0; i < text.Count - 2; i++)
        {
            var maxLength = Math.Min(text[i].Length - 1, Math.Min(text[i + 1].Length - 2, text[i + 2].Length - 1));
            for (int j = 0; j < maxLength; j++)
            {
                var first = text[i][j + 1];
                var second = text[i + 1][j];
                var third = text[i + 1][j + 1];
                var fourth = text[i + 1][j + 2];
                var fifth = text[i + 2][j + 1];
                if (first == second && second == third && third == fourth && fourth == fifth)
                {
                    output[i][j + 1] = '\0';
                    output[i + 1][j] = '\0';
                    output[i + 1][j + 1] = '\0';
                    output[i + 1][j + 2] = '\0';
                    output[i + 2][j + 1] = '\0';
                }
            }
        }
        foreach (var arr in output)
        {
            foreach (var ch in arr)
            {
                if (ch != '\0')
                {
                    Console.Write(ch);
                }
            }
            Console.WriteLine();
        }
    }
}

