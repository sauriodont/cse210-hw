using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int square;
        string name;
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            return name;
        }
        int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            return number;
        }
        int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }

        name = PromptUserName();
        number = PromptUserNumber();
        square = SquareNumber(number);
        void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }
        DisplayWelcome();
        DisplayResult(name, square);

        
        
    }
}