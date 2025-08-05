using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor sin parámetros
    public Activity()
    {
        _name = "Generic Activity";
        _description = "This is a generic activity.";
        _duration = 0;
    }

    // Constructor con parámetros (usado por clases derivadas)
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Mensaje inicial
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("Enter duration in seconds: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Defaulting to 30 seconds.");
            _duration = 30;
        }

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(5);
    }

    // Mensaje final
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(5);
    }

    // Animación tipo spinner
    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        string[] symbols = { "+", "-", "*", "#" };
        int i = 0;

        while (DateTime.Now < futureTime)
        {
            Console.Write(symbols[i % symbols.Length]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
        }
    }

    // Cuenta regresiva
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    // Getter para duración
    public int GetDuration()
    {
        return _duration;
    }
}