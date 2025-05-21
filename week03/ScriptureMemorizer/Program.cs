using System;
namespace ScriptureMemorizer;
class Program
    {
        static void Main(string[] args)
        {
                // Initialize the scripture reference and text
                Reference reference = new Reference("John", 3, 16);
                Scripture scripture = new Scripture("For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
                string referenceText = reference.GetReference();
                string scriptureText = scripture.GetText();
                Console.WriteLine(referenceText + " " + scriptureText);

                // Init the number of words to hide
                int wordsToHide = 3;  // Maskr 3 words at a time

            // Mask progressively
            do
            {
                Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "quit")
                {
                    break;  // quit the program
                }
                else if (string.IsNullOrEmpty(userInput))
                { 
                string maskedText = scripture.HideWordsProgressively(wordsToHide);
                Console.Clear(); // clear the console for a fresh display
                Console.WriteLine($"Iteration (Masking {wordsToHide} words):");
                Console.WriteLine(referenceText + " " + maskedText);  // dispay the scripture with masked words
                }
                else
                {
                    Console.WriteLine("Invalid input. Please press Enter or type 'quit'.");
                }

                // increase the number of words to hide for the next iteration
                wordsToHide += 3;
        
            } while (scripture.GetHiddenWordCount() < scripture.GetWordCount());
            
        }
    }