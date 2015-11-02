using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class TerroristWin
{
    static void Main()
    {
        string input = Console.ReadLine();
        StringBuilder sb = new StringBuilder(input);
        string[] text = input.Split('|');
        List<string> bombs = new List<string>();
        var bombPower = new List<int>();
        int power = 0;
        for (int i = 1; i < text.Length; i += 2)
        {
            bombs.Add(text[i]);
        }
        for (int i = 0; i < bombs.Count; i++)
        {
            List<byte> asci = Encoding.ASCII.GetBytes(bombs[i]).ToList();
            int sum = 0;
            power = 0;
            foreach (var number in asci)
            {
                sum += number;
            }
            power = sum % 10;
            bombPower.Add(power);
        }
        int startIndex = input.IndexOf("|");
        List<int> temp = new List<int>();
        int temporal = 0;
        for (int i = 0; i < bombs.Count; i++)
        {
            temporal = 0;
            temporal = 2 * bombPower[i] + bombs[i].Length + 2;

            temp.Add(temporal);
        }
        for (int i = 0; i < bombs.Count; i++)
        {
            int start = startIndex - bombPower[i];
            int end = startIndex + bombs[i].Length + 2 + bombPower[i];
            if (startIndex < bombPower[i])
            {
                start = startIndex;
            }
            for (int j =start ; j < end; j++)
            {
                sb[j] = '.';
            }
            startIndex = (startIndex + bombs[i].Length + 1 + text[i + 2].Length + 1);
            
        }
        Console.WriteLine(sb);
    }
}
//using System;
//using System.Text;

//class TerroristsWin
//{
//    static void Main()
//    {
//        string inputText = Console.ReadLine();

//        StringBuilder inputTextAsStringBuilder = new StringBuilder(inputText);
//        int startIndex = inputText.IndexOf('|');
//        int endIndex = 0;
//        int unicodeSum = 0;
//        int destroyedArea = 0;
//        while (startIndex != -1)
//        {
//            unicodeSum = 0;
//            endIndex = inputText.IndexOf('|', startIndex + 1);
//            if (endIndex <= startIndex)
//            {
//                break;
//            }
//            for (int i = startIndex + 1; i <= endIndex - 1; i++)
//            {
//                unicodeSum += inputText[i];
//                inputTextAsStringBuilder[i] = '.';
//            }
//            destroyedArea = unicodeSum % 10;

//            for (int i = startIndex; i >= startIndex - destroyedArea && i >= 0; i--)
//            {
//                inputTextAsStringBuilder[i] = '.';
//            }
//            for (int i = endIndex; i <= endIndex + destroyedArea && i < inputTextAsStringBuilder.Length; i++)
//            {
//                inputTextAsStringBuilder[i] = '.';
//            }

//            startIndex = inputText.IndexOf('|', endIndex + 1);
//        }
//        Console.WriteLine(inputTextAsStringBuilder);
//    }
//}
