using System;
using System.Text;
class ReverseNumber
{
    static void Main()
    {
        double number = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(number);
        Console.WriteLine(reversed);
    }
    public static double GetReversedNumber(double num)
    {
        string str = num.ToString();
        StringBuilder sb = new StringBuilder();
        if (string.IsNullOrEmpty(str))
        {
            return num;
        }
        for (int i = str.Length - 1; i >= 0; i--)
        {
            sb.Append(str[i]);
        }
        double result = double.Parse(sb.ToString());
        return result;
    }
}

