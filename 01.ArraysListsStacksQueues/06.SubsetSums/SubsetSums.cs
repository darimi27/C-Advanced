﻿using System;
using System.Collections.Generic;
using System.Linq;
class SubsetSums
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
        bool match = false;
        int comb = (int)Math.Pow(2, arr.Length);
        for (int mask = 1; mask < comb; mask++)
        {
            List<int> currCombo = new List<int>();
            for (int bit = 0; bit < arr.Length; bit++)
            {
                if ((mask >> bit & 1) == 1)
                {
                    currCombo.Add(arr[bit]);
                }
            }

            if (currCombo.Sum() != sum) continue;

            Console.WriteLine("{0} = {1}", string.Join(" + ", currCombo), sum);
            match = true;
        }

        if (!match)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}

