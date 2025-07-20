using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("Proverbs", 3, 5, 6);
    string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\n I hope you have memorized it");
                break;
            }

            Console.WriteLine("\nPress ENTER to hide words o 'quit' to terminate.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(1);
        }

        Console.WriteLine("\nThanks for studying the Gospel. 🙏");
    }
}