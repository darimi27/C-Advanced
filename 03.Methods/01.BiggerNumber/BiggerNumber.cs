using System;
class BiggerNumber
{
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }
    public static int GetMax(int first, int second)
    {
        int max = int.MinValue;
        if (first > second)
        {
            max = first;
        }
        else
        {
            max = second;
        }
        return max;
    }
}
