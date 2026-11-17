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

            string[] words = input.Split(' ');
            int wordCount = words.Length;

            string longestWord = "";
            string wordWithMostVowels = "";
            int maxVowelCount = -1;

            string vowels = "aeiouyæøåAEIOUYÆØÅ";

            foreach (string word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }

                int currentVowelCount = 0;
                foreach (char c in word)
                {
                    if (vowels.Contains(c))
                    {
                        currentVowelCount++;
                    }
                }

                if (currentVowelCount > maxVowelCount)
                {
                    maxVowelCount = currentVowelCount;
                    wordWithMostVowels = word;
                }
            }

            return $"Antall ord: {wordCount}\n" +
                   $"Lengste ord: {longestWord}\n" +
                   $"Flest vokaler: {wordWithMostVowels} ({maxVowelCount} stk)";
        }
    }
}