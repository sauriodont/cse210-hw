using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What's your first name? ");
        string name = Console.ReadLine();
        Console.Write("What's your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine($" Your name is {lastname}, {name} {lastname}.");
    }
}