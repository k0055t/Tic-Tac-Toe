using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class WinChecker
    {
        public bool Check(int player, char[,] board)
        {
            char symbol = 'a';
            if (player == 1)
            {
                symbol = 'o';
            }
            else
            {
                symbol = 'x';
            }
            if (CheckColumns(symbol, board) || CheckRows(symbol, board) || CheckDiagonals(symbol, board))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool CheckDiagonals(char symbol, char[,] board)
        {
            if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
            {
                return true;
            }

            if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        bool CheckRows(char symbol, char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == symbol && board[i, 1] == symbol && board[i, 2] == symbol)
                {
                    return true;
                }
            }
            return false;
        }

        bool CheckColumns(char symbol, char[,] board)
        {
            for (int i = 0; i < board.GetLength(1); i++)
            {
                if (board[0, i] == symbol && board[1, i] == symbol && board[2, i] == symbol)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
