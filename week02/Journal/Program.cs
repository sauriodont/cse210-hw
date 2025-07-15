using System;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        int option = 0;
        Journal journal = new Journal();
        PromptGenerator selection = new PromptGenerator();
        string filename = "Journal.txt";
        while (option != 5)
        {
            Console.WriteLine("Please Select one of the following options.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            String user = Console.ReadLine();
            option = int.Parse(user);
            if (option == 1)
            {
                string randomprompt = selection.GetRandomPrompt();
                Console.WriteLine(randomprompt);
                String response = Console.ReadLine();
                Entry newEntry = new Entry();
                newEntry._promtText = randomprompt;
                newEntry._entryText = response;
                newEntry._date = DateTime.Now.ToShortDateString();
                journal.AddEntry(newEntry);
            }

            if (option == 2)
            {
                journal.DisplayAll();
            }
            if (option == 3)
            {
                journal.SaveToFile(filename);
                journal._entries.Clear();

            }
            if (option == 4)
            {
                journal.LoadFromFile(filename);
            }

            if (option == 5)
            {
                Console.WriteLine("Good Bye!");
                break;
            }
        }
    }
}