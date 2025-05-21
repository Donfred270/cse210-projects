using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        // Text of the scripture
        private string _text;
        private HashSet<int> _hiddenIndices = new HashSet<int>();  // To keep track of hidden words

        // Constructor
        public Scripture(string text)
        {
            _text = text;
        }

        // Display the scripture text
        public void Display()
        {
            Console.WriteLine(_text);
        }

        // Method to hide words progressively
        public string HideWordsProgressively(int numberOfWordsToHide)
        {
            // Split the text into words
            List<string> words = new List<string>(_text.Split(' '));
            Random random = new Random();

            // Randomly select indices to hide until we reach the required number
            while (_hiddenIndices.Count < numberOfWordsToHide && _hiddenIndices.Count < words.Count)
            {
                int randomIndex = random.Next(words.Count);  // Select a random index
                _hiddenIndices.Add(randomIndex);  // Add the index to the HashSet (unique indices)
            }

            // Replace the selected words with underscores
            for (int i = 0; i < words.Count; i++)
            {
                if (_hiddenIndices.Contains(i))
                {
                    words[i] = new string('_', words[i].Length);  // Replace the word with underscores
                }
            }

            return string.Join(" ", words);  // Join the words back into a single string
        }
         public int GetHiddenWordCount()
        {
            return _hiddenIndices.Count;
        }

          public int GetWordCount()
        {
            return _text.Split(' ').Length;
        }

        // Method to get the original text
        public string GetText()
        {
            return _text;
        }
    }
}
