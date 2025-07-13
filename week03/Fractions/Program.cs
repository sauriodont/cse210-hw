using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.fractionText());
        Console.WriteLine(f1.numDecimal());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.fractionText());
        Console.WriteLine(f2.numDecimal());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.fractionText());
        Console.WriteLine(f3.numDecimal());

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.fractionText());
        Console.WriteLine(f4.numDecimal());
    }
}