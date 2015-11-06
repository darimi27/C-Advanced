using System;
class LargerThanNeighbours
{
    private static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }
    public static bool IsLargerThanNeighbours(int[] numbers, int i)
    {
        bool result = false;
        if (i == 0)
        {
            result = numbers[i] > numbers[i + 1];
        }
        if (i > 0 && i < numbers.Length - 1)
        {
            result = (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1]);
        }
        if (i == numbers.Length - 1)
        {
            result = numbers[i] > numbers[i - 1];
        }
        return result;
    }
}

