using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp7
{
    class UserInput
    {
        public int Load(int player, char[,] board)
        {
            Console.WriteLine("\nPlayer {0} what place will you choose?", player);
            Console.Write("Field number: ");
            string input = Console.ReadLine();
            int fieldNumber;

            if (int.TryParse(input, out fieldNumber))
            {
                int counter = 0;
                for (int i = 0; i < board.GetLength(0); i++)
                {
                    for (int j = 0; j < board.GetLength(1); j++)
                    {
                        counter++;
                        if (fieldNumber == counter)
                        {
                            if (board[i, j] != 'o' && board[i, j] != 'x')
                            {
                                return fieldNumber;
                            }
                            else
                            {
                                Console.WriteLine("\nThe field is full yet, take some other");
                                return Load(player, board);
                            }
                        }
                    }
                }
                Console.WriteLine("\nNot a valid field, please enter a valid field");
                return Load(player, board);
            }
            else
            {
                Console.WriteLine("\nNot a valid field, please enter a valid field");
                return Load(player, board);
            }
        }
    }
}
