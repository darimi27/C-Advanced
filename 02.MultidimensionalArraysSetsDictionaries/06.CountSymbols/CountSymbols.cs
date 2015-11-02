using System;
using System.Collections.Generic;
using System.Linq;
class CountSymbols
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<char> list = input.ToList();
        SortedDictionary<char, int> occurence = new SortedDictionary<char, int>();
        int count = 0;
        for (int i = 0; i < list.Count; i++)
        {
            count = list.Count(p => p == list[i]);
            occurence[list[i]] = count;
        }
        foreach (var entry in occurence)
        {
            Console.WriteLine("{0}: {1} time/s", entry.Key, entry.Value);
        }
    }
}

