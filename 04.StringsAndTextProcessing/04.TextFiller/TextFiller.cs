using System;
using System.Text;
class TextFiller
{
    static void Main()
    {
        string[] bannedWords = Console.ReadLine().Trim().Split(new char[]{',',' '},StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();
        StringBuilder sb=new StringBuilder(text);
        Console.WriteLine();
        for (int i = 0; i < bannedWords.Length; i++)
        {
            sb.Replace(bannedWords[i], new string('*', bannedWords[i].Length));
        }
        Console.WriteLine(sb);
    }
}

