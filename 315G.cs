namespace GetAcademyTasks
{
    internal class _315G
    {
        public static void GetAcademyFunction()
        {
            int range = 250;
            int[] counts = new int[range];
            string? text = "something";


            int totalCharacters = 0;


            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine()?.ToLower();

                foreach (char character in text)
                {
                    counts[character]++;
                    totalCharacters++;
                }
                for (int i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        char character = (char)i;

                        double percentage = totalCharacters > 0 ? ((double)counts[i] / totalCharacters) * 100 : 0;

                        Console.WriteLine($"{character} - Count: {counts[i]} ({percentage}%)");
                    }
                }
            }
        }
    }
}
