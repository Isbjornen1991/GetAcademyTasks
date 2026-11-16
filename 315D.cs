using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Channels;

namespace GetAcademyTasks
{
    public class _315D
    {
        public static string CounterFunction(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "No input provided.";
            }

            // 1. Split into words
            string[] words = input.Split(' ');
            int wordCount = words.Length;

            // Variables to track our results
            string longestWord = "";
            string wordWithMostVowels = "";
            int maxVowelCount = -1;

            // Define Norwegian vowels (both lower and uppercase)
            string vowels = "aeiouyæøåAEIOUYÆØÅ";

            foreach (string word in words)
            {
                // Check for longest word
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

                // Count vowels for the current word
                int currentVowelCount = 0;
                foreach (char c in word)
                {
                    // If our vowel string contains the current character, count it!
                    if (vowels.Contains(c))
                    {
                        currentVowelCount++;
                    }
                }

                // Check if this word has the most vowels found so far
                if (currentVowelCount > maxVowelCount)
                {
                    maxVowelCount = currentVowelCount;
                    wordWithMostVowels = word;
                }
            }

            // 4. Return all the statistics neatly formatted
            return $"Antall ord: {wordCount}\n" +
                   $"Lengste ord: {longestWord}\n" +
                   $"Flest vokaler: {wordWithMostVowels} ({maxVowelCount} stk)";
        }
    }
}