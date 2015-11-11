using System;
using System.Text;
class StringLength
{
    static void Main()
    {
        string input = Console.ReadLine();
        if (input.Length>20)
        {
            string output = input.Substring(0, 20);
            Console.WriteLine(output);
        }
        else
        {
            int length = 20 - input.Length;
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < length; i++)
            {
                sb.Append("*");
            }
            Console.WriteLine(sb);
        }
    }
}

