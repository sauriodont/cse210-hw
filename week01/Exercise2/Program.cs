using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string plus = "";
        int rest;
        Console.Write("Enter your grade: ");
        String grade = Console.ReadLine();
        int number = int.Parse(grade);
        rest = number % 10;
        if (number >= 60 && number < 94)
        {
            if (rest >= 7)
            {
                plus = "+";
            }
            else if (rest <= 3)
            {
                plus = "-";
            }
            else{
                plus = "";
            }
        }

        if (number >= 90)
            {
                letter = "A";
            }
            else if (number >= 80)
            {
                letter = "B";
            }
            else if (number >= 70)
            {
                letter = "C";
            }
            else if (number >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
        Console.WriteLine($"Your grade is: {letter}{plus}");
        if (number > 70)
        {
            Console.WriteLine($"Congratulations you made it.");
        }
        else
        {
            Console.WriteLine("You're on the way, make an extra effort next time.");
        }
    }
}