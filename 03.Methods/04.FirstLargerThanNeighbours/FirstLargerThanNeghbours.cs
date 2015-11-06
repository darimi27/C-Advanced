using System;
class FirstLargerThanNeghbours
{
    static void Main()
    {
        int[] sequenceOne = {1, 3, 4, 5, 1, 0, 5};
        int[] sequenceTwo = {1, 2, 3, 4, 5, 6, 6};
        int[] sequenceThree = {1, 1, 1};
        Console.WriteLine(GetIndexOfFirstElemenetLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElemenetLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElemenetLargerThanNeighbours(sequenceThree));
    }
    public static int GetIndexOfFirstElemenetLargerThanNeighbours(int[] arr)
    {
        int output = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0&&arr[i] > arr[i + 1])
            {
                output = i;
                break;
            }
            else if ((i > 0 && i < arr.Length - 1) && (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]))
            { 
                output = i;
                break;
            }
            else if (i == arr.Length - 1 && arr[i] > arr[i - 1])
            {
                output = i;
                break;
            }
            else
            {
                output = -1;
            }
        }       
        return output;
    }
}

