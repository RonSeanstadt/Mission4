using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        /// <summary>
        /// This method receives the board array and prints the board.
        /// This is how the board array should look:
        /// char[,] board =
        /// {
        ///     { 'X', 'O', 'X' },
        ///     { ' ', 'X', 'O' },
        ///     { 'O', ' ', ' ' }
        /// };
        /// </summary>
        /// <param>3x3 2-dimensional array</param>
        /// <returns>Null</returns>
        public static void Print(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {board[i, j]} ");

                    if (j < 2)
                    {
                        Console.Write("|");
                    }

                }

                Console.WriteLine();
                
                if (i < 2)
                {
                    Console.WriteLine("---+---+---");
                }
            }
        }

        /// <summary>
        /// This method also receives the board array,
        /// but also checks for who the winner is (if there is one).
        /// If not, it just returns the null character ('\O').
        /// char[,] board =
        /// {
        ///     { 'X', 'O', 'X' },
        ///     { ' ', 'X', 'O' },
        ///     { 'O', ' ', ' ' }
        /// };
        /// </summary>
        /// <param>3x3 2-dimensional array</param>
        /// <returns>Null</returns>
        public static char CheckForWinner(char[,] board)
        {
            // Check diagonals
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return board[0, 0];
            }

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return board[0, 2];
            }

            // Check horizontals
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return board[i, 0];
                }
            }

            // Check verticals
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j])
                {
                    return board[0, j];
                }
            }

            // No winner
            //return '\0';

            return 'y';

        }
    }
}
