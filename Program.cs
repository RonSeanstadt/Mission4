using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class program
    {
        static void Main(string[] args)
        {
            char[,] board =
            {
                { 'X', 'O', 'O' },
                { 'O', 'X', 'O' },
                { 'X', ' ', 'O' }
            };

            Board.Print(board);

            Console.WriteLine(Board.CheckForWinner(board));
        }
    }
}