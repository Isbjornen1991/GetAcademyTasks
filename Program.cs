namespace GetAcademyTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nWhat would you like to do? Type 'reverse', 'longest', 'fit', 'play', 'game' or 'exit'");
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
                else if (action == "fit")
                {
                    int inputStart = 0;
                    bool validStart = false;
                    while (!validStart)
                    {
                        Console.WriteLine("Enter a number to start from.");
                        if (int.TryParse(Console.ReadLine(), out inputStart))
                        {
                            validStart = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a whole number.");
                        }
                    }

                    int inputEnd = 0;
                    bool validEnd = false;
                    while (!validEnd)
                    {
                        Console.WriteLine("Enter a number to end at.");
                        if (int.TryParse(Console.ReadLine(), out inputEnd))
                        {
                            validEnd = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a whole number.");
                        }
                    }

                    int inputInterval = 0;
                    bool validInterval = false;
                    while (!validInterval)
                    {
                        Console.WriteLine("Enter the number to increase by.");
                        if (int.TryParse(Console.ReadLine(), out inputInterval))
                        {
                            validInterval = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a whole number.");
                        }
                    }

                    int[] generaedArray = _315E.GenerateNumberArray(inputStart, inputEnd, inputInterval);

                    Console.WriteLine($"Generated numbers: {string.Join(", ", generaedArray)}");
                }
                else if (action == "play")
                {
                    _315F.RunGame();
                }
                else if (action == "game")
                {
                    RockScissPaper.RunGame();
                }
                else
                {
                    Console.WriteLine("Unknown command, try again.");
                }
            }
        }
    }
}