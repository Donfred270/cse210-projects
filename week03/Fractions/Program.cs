using System;
namespace Fractions;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fractions fraction1 = new Fractions(6, 8);
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {fraction1.GetDecimalValue()}");

    }
}