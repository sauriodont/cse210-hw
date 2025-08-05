using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment n1 = new Assignment("Linda Waters", "Math Expresions");
        Console.WriteLine(n1.GetSummary());

        MathAssignment n2 = new MathAssignment("Albert Connor", "Square root", "18", "15-22");
        Console.WriteLine(n2.GetSummary());
        Console.WriteLine(n2.GetHomeworkList());

        WritingAssignment n3 = new WritingAssignment("Lucy Hamilton", "American History", "USA Independency");
        Console.WriteLine(n3.GetSummary());
        Console.WriteLine(n3.GetWritingInformation());
    }
}