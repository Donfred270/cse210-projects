using System;
namespace homework;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment = new Assignment("Donfred Vallon", "Coding");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment math1 = new MathAssignment("Donfred Vallon", "Fractions", "9", "10, 11, 17");
         Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());
    }
}