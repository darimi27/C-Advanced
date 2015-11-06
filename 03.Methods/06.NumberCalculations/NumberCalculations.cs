using System;
using System.Collections.Generic;
using System.Linq;
//minimum, maximum, average, sum and product 
class NumberCalculations
{
    static void Main()
    {
        List<double> doub = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
        List<decimal> dec=Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
        Console.WriteLine("The minimum of this set of doubles is : {0}", Minimum(doub));
        Console.WriteLine("The minimum of this set of decimals is : {0}",Minimum(dec));
        Maximum(doub);
        Maximum(dec);
        Average(doub);
        Average(dec);
        Sum(doub);
        Sum(dec);
        Product(doub);
        Product(dec);
    }
    public static double Minimum(List<double> doubles)
    {
       return doubles.Min();
    }
    public static decimal Minimum(List<decimal> decimals)
    {
        return decimals.Min();
    }
    public static void Maximum(List<double> doubles)
    {
        Console.WriteLine("The maximum of this set of doubles is : {0}", doubles.Max());
    }
    public static void Maximum(List<decimal> decimals)
    {
        Console.WriteLine("The maximum of this set of decimals is : {0}", decimals.Max());
    }
    public static void Average(List<double> doubles)
    {
        Console.WriteLine("The average of this set of doubles is : {0}", doubles.Average());
    }
    public static void Average(List<decimal> decimals)
    {
        Console.WriteLine("The average of this set of decimals is : {0}", decimals.Average());
    }

    public static void Sum(List<double> doubles)
    {
        double sum = 0;
        foreach (var num in doubles)
        {
            sum += num;
        }
        Console.WriteLine("The sum of this set of doubles is : {0}", sum);
    }
    public static void Sum(List<decimal> decimals)
    {
        decimal sum = 0;
        foreach (var num in decimals)
        {
            sum += num;
        }
        Console.WriteLine("The sum of this set of decimals is : {0}", sum);
    }
    public static void Product(List<double> doubles)
    {
        double product = 1;
        foreach (var num in doubles)
        {
            product *= num;
        }
        Console.WriteLine("The product of this set of doubles is : {0}", product);
    }
    public static void Product(List<decimal> decimals)
    {
        decimal product = 1;
        foreach (var num in decimals)
        {
            product *= num;
        }
        Console.WriteLine("The product of this set of decimals is : {0}", product);
    }

}

