namespace GetAcademyTasks
{
    internal class _315F
    {


        public static void drawBoard(int[,] board)
        {
            Console.Clear();
            Console.WriteLine("--- SLIDING PUZZLE ---");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {

                    int value = board[row, col];

                    if (value == 0)
                    {
                        Console.Write("[   ]");
                    }
                    else
                    {
                        Console.Write($"[ {value} ]");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void RunGame()
        {
            int[,] board = {
                            { 0, 1, 3 },
                            { 4, 2, 5 },
                            { 7, 8, 6 }
                           };

            bool playing = true;

            while (playing)
            {
                drawBoard(board);
                Console.WriteLine("\nUse W (Up), S (Down), A (Left), D (Right) to move. Type 'q' to quit.");
                string move = Console.ReadLine()?.Trim().ToLower();

                if (move == "q")
                {
                    playing = false;
                    break;
                }

                // Step 1: Find the current row and col of the blank space (0)
                int blankRow = -1;
                int blankCol = -1;

                for (int r = 0; r < 3; r++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (board[r, c] == 0)
                        {
                            blankRow = r;
                            blankCol = c;
                        }
                    }
                }

                // Step 2: Determine target coordinates based on input
                int targetRow = blankRow;
                int targetCol = blankCol;

                if (move == "w") targetRow++;      // Moving 'W' means the tile below moves UP into the blank
                else if (move == "s") targetRow--; // Moving 'S' means the tile above moves DOWN into the blank
                else if (move == "a") targetCol++; // Moving 'A' means the tile to the right moves LEFT
                else if (move == "d") targetCol--; // Moving 'D' means the tile to the left moves RIGHT

                // Step 3: Check if the target is within the 3x3 grid boundaries
                if (targetRow >= 0 && targetRow < 3 && targetCol >= 0 && targetCol < 3)
                {
                    // Swap the numbers!
                    int temp = board[targetRow, targetCol];
                    board[targetRow, targetCol] = board[blankRow, blankCol];
                    board[blankRow, blankCol] = temp;
                }
                else
                {
                    Console.WriteLine("Invalid move! Hit a wall.");
                    Console.ReadKey(); // Pause so they can read the warning
                }
            }
        }


    }


}
