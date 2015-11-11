using System;
using System.Collections.Generic;
using System.Text;
class Palindromes
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(new char []{' ',',','.','?','!'},StringSplitOptions.RemoveEmptyEntries);
        SortedSet<string> palindromes = new SortedSet<string>();
        for (int i = 0; i < input.Length; i++)
        {
            StringBuilder sb = new StringBuilder(input[i]);
            if (sb.Length == 1)
            {
                palindromes.Add(input[i]);
            }
            else
            {
                for (int j = 0; j < input[i].Length/2; j++)
                {
                    if (sb[j].Equals(sb[sb.Length - 1 - j]))
                    {
                        palindromes.Add(input[i]);
                    } 
                }                
            }
        }
        Console.Write(string.Join(", ",palindromes));
        Console.WriteLine();
    }
}

