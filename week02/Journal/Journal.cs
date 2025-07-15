using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }
    public void DisplayAll()
    {
        Console.WriteLine("Total de entradas: " + _entries.Count);
                if (_entries.Count == 0)
                    {
                        Console.WriteLine("No entries yet.");
                        return;
                    }
        foreach (Entry entry in _entries)
            {
                Console.WriteLine("----");
                Console.WriteLine($"Date: {entry._date}");
                Console.WriteLine($"Question: {entry._promtText}");
                Console.WriteLine($"Answer: {entry._entryText}");
            }
    }
    public void SaveToFile(string filename)
    {
        
        using (StreamWriter outputFile = new StreamWriter(filename, append: true))

        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date};{entry._promtText};{entry._entryText}");
            }
        }

        

    }

    public void LoadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(";");

            string date = parts[0];
            string question = parts[1];
            string Answer = parts[2];
            Console.WriteLine($"{date} {question} {Answer}");
        }
    }

}