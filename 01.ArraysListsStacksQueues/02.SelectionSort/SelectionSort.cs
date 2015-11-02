using System;
using System.Linq;
class SelectionSort
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] arr = input.Split().Select(int.Parse).ToArray();
        for (int j = 0; j < arr.Length - 1; j++)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int temp;
                if (arr[i] > arr[i + 1])
                {
                    temp = arr[i];
                    arr[i] = arr[i + 1];
                    arr[i + 1] = temp;
                }
            }
        }
        Console.Write(string.Join(" ", arr));

    }
}

