using System;
using System.Linq;
class SequencesOfEqualsStrings
{
    static void Main()
    {
        var input = Console.ReadLine().Split();
        for (int i = 0; i < input.Count() - 1; i++)
        {
            Console.Write(input[i] + " ");
            if (input[i].Equals(input[i + 1]))
            {
                continue;
            }
            else
            {
                Console.WriteLine();
            }
        }
        Console.Write(input[input.Length - 1]);
        Console.WriteLine();
    }
}

