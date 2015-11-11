using System;
class UnicodeCharacters
{
    static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();
        string[] output = new string[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            output[i] = String.Format(@"\u{0:x4}", (ushort)input[i]);  
        }
        foreach (var unicodeChar in output)
        {
            Console.Write(unicodeChar);
        }
        Console.WriteLine();
    }
}

