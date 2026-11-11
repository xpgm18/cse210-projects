using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Fractions Project.");
        // Fraction f1 = new Fraction();
        // Console.WriteLine(f1.GetTop());
        // Console.WriteLine(f1.GetBottom());
        // f1.SetBottom(10);
        // f1.SetTop(2);
        // Console.WriteLine($"Changed values: Top = {f1.GetTop()} Bottom = {f1.GetBottom()}");
        // Fraction f2 = new Fraction(5);
        // Console.WriteLine(f2.GetTop());
        // Console.WriteLine(f2.GetBottom());
        // Fraction f3 = new Fraction(5,4);
        // Console.WriteLine(f3.GetTop());
        // Console.WriteLine(f3.GetBottom());

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}