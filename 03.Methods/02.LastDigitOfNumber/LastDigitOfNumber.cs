using System;
class LastDigitOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(GetLastDigitAsWord(number));
    }
    public static string GetLastDigitAsWord(int num)
    {
        int lastDigit = num % 10;
        string[] arr = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int[] numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string result = null;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (lastDigit == numbers[i])
            {
                result = arr[i];
            }
        }
        return result;
    }
}

