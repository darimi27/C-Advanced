using System;
using System.Linq;
class SortArrayOfNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] arr = input.Split().Select(int.Parse).ToArray();
        Array.Sort(arr);
        foreach (var i in arr)
        {
            Console.WriteLine(i);
        }
    }
}

