using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        long count = 0;
        string tempString = input;
        
        while (true)
        {
            if (tempString.Length == 1)
            {
                Console.Write(tempString + " " + count);
                break;
            }
            tempString = SumDigits(tempString);
            count++;
        }
    }

    public static string SumDigits(string input)
    {
        ulong sum = 0;
        for (var i = 0; i < input.Length; i++)
        {
            sum = ulong.Parse(input[i].ToString()) + sum;
        }
        
        return Convert.ToString(sum);
    }
}