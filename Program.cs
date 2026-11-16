namespace GetAcademyTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            // This keeps the program alive until the user wants to quit
            while (keepRunning)
            {
                Console.WriteLine("\nWhat would you like to do? Type 'reverse', 'longest', or 'exit'");
                string action = Console.ReadLine();

                if (action == "exit")
                {
                    keepRunning = false;
                    Console.WriteLine("Exiting program. Goodbye!");
                }
                else if (action == "reverse")
                {
                    Console.WriteLine("Enter some text to reverse: ");
                    string userInput = Console.ReadLine();
                    string reversedText = TextHelper.ReverseString(userInput);
                    Console.WriteLine($"Reversed: {reversedText}");
                }
                else if (action == "longest")
                {
                    Console.WriteLine("Enter a sentence or text to analyze: ");
                    string userInput = Console.ReadLine();
                    string result = _315D.CounterFunction(userInput);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("Unknown command, try again.");
                }
            }
        }
    }
}