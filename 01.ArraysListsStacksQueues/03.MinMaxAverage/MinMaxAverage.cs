using System;
using System.Collections.Generic;
using System.Linq;
class MinMaxAverage
{
    static void Main()
    {
        double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
        var roundNumbers = new List<double>();
        var floatingPointNumbers = new List<double>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 1 == 0)
            {
                roundNumbers.Add(nums[i]);
            }
            else
            {
                floatingPointNumbers.Add(nums[i]);
            }
        }
        Console.WriteLine("[" + string.Join(", ", floatingPointNumbers) + "]" + " -> " + "min: {0:f2}, max: {1:f2},sum: {2:f2}, avg: {3:f2}", floatingPointNumbers.Min(), floatingPointNumbers.Max(), floatingPointNumbers.Sum(), floatingPointNumbers.Average());
        Console.WriteLine("[" + string.Join(", ", roundNumbers) + "]" + " -> " + "min: {0}, max: {1},sum: {2}, avg: {3:f2}", roundNumbers.Min(), roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average());

    }
}

