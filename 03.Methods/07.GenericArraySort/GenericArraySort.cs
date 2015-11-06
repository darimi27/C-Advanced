using System;
class GenericArraySort
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        string[] strings = { "zaz", "cba", "baa", "azis" };
        DateTime[] dates =
        {
            new DateTime(2002, 3, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2014, 1, 1),
        };

        SortArray(numbers);
        Console.WriteLine();
        SortArray(strings);
        Console.WriteLine();
        SortArray(dates);
        Console.WriteLine();
    }
    private static void SortArray<T>(T[] array)
    {
        Array.Sort(array);
        foreach (var element in array)
        {
            Console.Write(element + ", ");
        }
        Console.WriteLine();
    }
}

