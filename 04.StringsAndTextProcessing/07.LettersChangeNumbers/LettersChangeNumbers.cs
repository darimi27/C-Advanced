using System;
using System.Linq;
using System.Text.RegularExpressions;
class LettersChangeNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] words = Regex.Split(input, @"\s+");
        char[] uppercase = new[]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'G', 'K', 'L', 'M',
            'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
        };
        char[] lowercase = new []
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m',
            'n','o','p','q','r','s','t','u','v','w','x','y','z'
        };
        int[] numbers=new int[26];
        for (int j = 0; j < 26; j++)
        {
            numbers[j] = j + 1;
        }
        char firstChar, secondChar;
        double firstNumber,secondNumber,number,result;
        double sumOfAllResults = 0d;
        for (int i = 0; i < words.Length; i++)
        {
            result = 0;
            firstChar = words[i][0];
            secondChar = words[i][words[i].Length - 1];

                if (uppercase.Contains(firstChar))
                {
                    firstNumber=Array.IndexOf(uppercase, firstChar)+1;
                }
                else
                {
                    firstNumber=Array.IndexOf(lowercase, firstChar)+1;
                }
                if (uppercase.Contains(secondChar))
                {
                    secondNumber = Array.IndexOf(uppercase, secondChar) + 1;
                }
                else
                {
                    secondNumber = Array.IndexOf(lowercase, secondChar) + 1;
                }
            Regex regex=new Regex(@"\d+");
            Match match = regex.Match(words[i]);
            number = double.Parse(match.Value);
            if (uppercase.Contains(firstChar)&&uppercase.Contains(secondChar))
            {
                result = number/firstNumber-secondNumber;
            }
            else if (uppercase.Contains(firstChar)&&lowercase.Contains(secondChar))
            {
                result = number/firstNumber+secondNumber;
            }
            else if (lowercase.Contains(firstChar)&&uppercase.Contains(secondChar))
            {
                result = number*firstNumber-secondNumber;
            }
            else 
            {
                result = number * firstNumber+secondNumber;
            }
            sumOfAllResults+= result;
        }
        Console.WriteLine("{0:f2}",sumOfAllResults);
    }
}

