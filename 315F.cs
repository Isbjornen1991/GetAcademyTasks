using System;
using System.Collections.Generic;
using System.Text;

namespace GetAcademyTasks
{
    internal class _315F
    {
        int[,] myBoard = {
            {0 , 1, 3},
            {4, 2, 5 },
            {7, 8, 6 },
        };

        public static void drawBoard(int[,] board)
        {
            Console.Clear();
            Console.WriteLine("--- SLIDING PUZZLE ---");

            for (int row = 0; row < 3; row++)
            {
                for(int col=0; col<3; col++)
                {

                    int value = board[row, col];

                    if (value == 0)
                    {
                        Console.Write("[ ]");
                    }
                    else
                    {
                        Console.Write($"[ {value} ]");
                    }
                }
                Console.WriteLine();
            }
        }




    }


}
