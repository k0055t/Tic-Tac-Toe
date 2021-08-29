using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{

    class BoardManager
    {

        char[,] board = new char[,]
        {
        { '1', '2', '3' },
        { '4', '5', '6' },
        { '7', '8', '9' }
        };

        public char[,] Get()
        {
            return board;
        }

        public void Render()
        {
            Console.Clear();
            Console.Write($"     |     |     \n" +
                $"  {board[0, 0]}  |  {board[0, 1]}  |  {board[0, 2]}  \n" +
                $"_____|_____|_____\n" +
                $"     |     |     \n" +
                $"  {board[1, 0]}  |  {board[1, 1]}  |  {board[1, 2]}  \n" +
                $"_____|_____|_____\n" +
                $"     |     |     \n" +
                $"  {board[2, 0]}  |  {board[2, 1]}  |  {board[2, 2]}  \n" +
                $"     |     |     \n");
        }

        public void Modify(int player, int field)
        {
            if (player == 1)
            {
                int counter = 0;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        counter++;
                        if (counter == field)
                            board[i, j] = 'o';
                    }
                }
            }
            else if (player == 2)
            {
                int counter = 0;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        counter++;
                        if (counter == field)
                            board[i, j] = 'x';
                    }
                }
            }
        }
    }
}
