using System;
class CountSubstringOccurrences
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        string search = Console.ReadLine().ToLower();
        int length = search.Length;
        int howmanytimes = input.Length - length + 1;
        int result = 0;
        for (int index = 0; index < howmanytimes; index++)
        {
            string theSubString = input.Substring(index, length);
            if (theSubString.ToLower() == search.ToLower())
            {
                result++;
            }
        }
        Console.WriteLine(result);
    }
}

