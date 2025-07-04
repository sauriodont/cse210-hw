using System;

class Program
{
    static void Main(string[] args)
    {
        string response;
        Random randomGenerator = new Random();
        Console.WriteLine("Try to guess the magic number");
        do
        {
            int number = randomGenerator.Next(1, 100);
            int guess = -1;
            while (guess != number){
            Console.Write("What is your guess?");
            String gues = Console.ReadLine();
            guess = int.Parse(gues);
            
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You made it");
                }


            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}