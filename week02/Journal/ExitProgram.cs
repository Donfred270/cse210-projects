using System;
namespace JournalApp;
public class ExitProgram
{
   
    public static void QuitProgram()
    {
        Console.WriteLine("Goodbye! Thank you for using the Journal Program.");
        Environment.Exit(0); 
    }
}
