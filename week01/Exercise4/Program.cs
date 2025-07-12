using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 1;
        float ave = 0;
        int sum = 0;
        int major = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            String user = Console.ReadLine();
            number = int.Parse(user);
            if (number != 0)
            {
                numbers.Add(number);
            }
            if (number > major)
            {
                major = number;
            }

            sum = sum + number;
            ave = (float)sum / numbers.Count;

        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {ave}");
        Console.WriteLine($"The largest number is: {major}");

    }
}