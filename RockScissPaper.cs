namespace GetAcademyTasks
{
    internal class RockScissPaper
    {



        public static void RunGame()
        {
            int playerWins = 0;
            int cpuWins = 0;
            bool playing = true;

            Console.WriteLine("Let's play Rock, Scissors, Paper!");

            while (playing)
            {
                Console.WriteLine("Make your choice, enter a number:");
                Console.WriteLine("""
                                    1. Rock
                                    2. Scissors
                                    3. Paper
                                   """);

                int cpuChoice = GenerateRandomNumber();
                int playerChoice = getPlayerInput();

                string roundResult = FindWinner(playerChoice, cpuChoice);

                if (roundResult == "player")
                {
                    playerWins++;
                }
                else if (roundResult == "cpu")
                {
                    cpuWins++;
                }

                Console.WriteLine(GetScoreMessage(playerWins, cpuWins));

                Console.WriteLine("\nPlay again? (y/n)");
                if (Console.ReadLine()?.Trim().ToLower() != "y")
                {
                    playing = false;
                }
            }
        }

        private static string GetScoreMessage(int playerWins, int cpuWins)
        {
            return $"The CPU has {cpuWins} wins, the player has {playerWins} wins.";
        }

        private static int getPlayerInput()
        {
            int chosenTool = 0;
            bool validChoice = false;

            while (!validChoice)
            {
                string? input = Console.ReadLine();

                if (int.TryParse(input, out chosenTool))
                {
                    if (chosenTool >= 1 && chosenTool <= 3)
                    {
                        validChoice = true;
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

        private static string FindWinner(int userChoice, int cpuChoice)
        {
            string userChoiceAsString = convertIntToName(userChoice);
            string cpuChoiceAsString = convertIntToName(cpuChoice);

            if (userChoice == cpuChoice)
            {
                Console.WriteLine($"You chose {userChoiceAsString}, the CPU chose {cpuChoiceAsString}. That's a draw!");
                return "draw";
            }
            else if (userChoice == 1 && cpuChoice == 2)
            {
                Console.WriteLine($"You chose {userChoiceAsString}, cpu chose {cpuChoiceAsString}. You win!");
                return "player";
            }

            else if (userChoice == 2 && cpuChoice == 3)
            {
                Console.WriteLine($"You chose {userChoiceAsString}, cpu chose {cpuChoiceAsString}. You win!");
                return "player";
            }

            else if (userChoice == 3 && cpuChoice == 1)
            {
                Console.WriteLine($"You chose {userChoiceAsString}, cpu chose {cpuChoiceAsString}. You win!");
                return "player";
            }
            else
            {
                Console.WriteLine($"You chose {userChoiceAsString}, cpu chose {cpuChoiceAsString}, You lose!");
                return "cpu";
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
