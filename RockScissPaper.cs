namespace GetAcademyTasks
{
    internal class RockScissPaper
    {

        public static void RunGame()
        {
            int cpuChoice = GenerateRandomNumber();

            Console.WriteLine("Let's play Rock, Scissors, Paper!");
            Console.WriteLine("Make your choice!");
            Console.WriteLine("Rock...");
            Console.WriteLine("Scissors...");
            Console.WriteLine("Paper...");
            Console.WriteLine("Make your choice, enter a number:");
            Console.WriteLine("""
                              1. Rock
                              2. Scissors
                              3. Paper

                              """);
            int playerChoice = getPlayerInput();




            findWinner(playerChoice, cpuChoice);

        }

        private static int getPlayerInput()
        {
            int chosenTool = 0;
            bool validChoice = false;

            while (!validChoice)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out chosenTool))
                {
                    if (chosenTool >= 1 && chosenTool <= 3)
                    {
                        validChoice = true; // 
                    }
                    else
                    {
                        Console.WriteLine("Uh oh, that's not a valid number. Try again!");
                    }
                }
                else
                {
                    Console.WriteLine("Uh oh, that's not a valid number. Try again!");
                }
            }

            return chosenTool;
        }

        private static void findWinner(int userChoice, int cpuChoice)
        {
            string userChoiceAsString = convertIntToName(userChoice);
            string cpuChoiceAsString = convertIntToName(cpuChoice);

            if (userChoice == cpuChoice)
            {
                Console.WriteLine($"You chose {userChoiceAsString}, the CPU chose {cpuChoiceAsString}. That's a draw!");
            }
            else if (userChoice == 1 && cpuChoice == 2)
            {
                Console.WriteLine($"You chose {userChoiceAsString}, cpu chose {cpuChoiceAsString}. You win!");
            }

            else if (userChoice == 2 && cpuChoice == 3)
            {
                Console.WriteLine($"You chose {userChoiceAsString}, cpu chose {cpuChoiceAsString}. You win!");
            }

            else if (userChoice == 3 && cpuChoice == 1)
            {
                Console.WriteLine($"You chose {userChoiceAsString}, cpu chose {cpuChoiceAsString}. You win!");
            }
            else
            {
                Console.WriteLine($"You chose {userChoiceAsString}, cpu chose {cpuChoiceAsString}, You lose!");
            }

        }

        private static int GenerateRandomNumber()
        {
            var random = new Random();
            int randomNumber = random.Next(1, 4);
            return randomNumber;
        }

        private static string convertIntToName(int choice)
        {
            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Scissors";
            }
            else
            {
                return "Paper";
            }
        }

    }
}
