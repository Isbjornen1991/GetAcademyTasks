namespace GetAcademyTasks
{
    internal class _315F
    {


        public static void DrawBoard(int[,] board)
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
                DrawBoard(board);
                Console.WriteLine("\nUse W (Up), S (Down), A (Left), D (Right) to move. Type 'q' to quit.");
                string? move = Console.ReadLine()?.Trim().ToLower();

                if (move == "q")
                {
                    playing = false;
                    break;
                }

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

                int targetRow = blankRow;
                int targetCol = blankCol;

                if (move == "w") targetRow--;
                else if (move == "s") targetRow++;
                else if (move == "a") targetCol--;
                else if (move == "d") targetCol++;

                if (targetRow >= 0 && targetRow < 3 && targetCol >= 0 && targetCol < 3)
                {
                    int temp = board[targetRow, targetCol];
                    board[targetRow, targetCol] = board[blankRow, blankCol];
                    board[blankRow, blankCol] = temp;

                    if (CheckWin(board))
                    {
                        DrawBoard(board);
                        Console.WriteLine("\n Congratulations! You solved the puzzle!");
                        playing = false;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid move! Hit a wall.");
                    Console.ReadKey();
                }
            }
        }

        private static bool CheckWin(int[,] currentBoard)
        {
            int[,] winningBoard = {
        { 1, 2, 3 },
        { 4, 5, 6 },
        { 7, 8, 0 }
    };

            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (currentBoard[r, c] != winningBoard[r, c])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }


}
