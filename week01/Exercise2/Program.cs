using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.WriteLine("what is the percentage of your grade? ");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        //determine the sign of the grade
        string gradeSign = "";
        int gradeSignInt = gradeInt % 10; 
        if (gradeSignInt >= 7)
        {
            gradeSign = "+";
        }
        else if (gradeSignInt < 3)
        {
            gradeSign = "-";
        }
         else
        {
            gradeSign = "";
        }

        //determine the letter grade
        if (gradeInt >= 90 && gradeInt <= 100)
        {
            letter = "A";
            Console.WriteLine($"You got an {letter}{gradeSign}!, you passed!");
        }
        else if (gradeInt >= 80 && gradeInt < 90)
        {
            letter = "B";
            Console.WriteLine($"You got a {letter}{gradeSign}! Congratulations, you passed!");
        }
        else if (gradeInt >= 70 && gradeInt < 80)
        {
            letter = "C";
            Console.WriteLine($"You got a {letter}{gradeSign}! Congratulations, you passed!");
        }
        else if (gradeInt >= 60 && gradeInt < 70)
        {
            letter = "D";
            int basicGrade = 70 - gradeInt;
            Console.WriteLine($"You got a {letter}{gradeSign}! you need to study more, you are {basicGrade} points away to passed this course.");
        }
        else if (gradeInt < 0 || gradeInt > 100)
        {
            Console.WriteLine("Invalid grade, please enter a number between 0 and 100.");
            return;
        }
        else
        {
            letter = "F";
            int basicGrade = 70 - gradeInt;
            Console.WriteLine($"You got an {letter}{gradeSign}!");
            Console.WriteLine($"You need to study more, you are {basicGrade} points away to passed this course.");
        }
    }
}