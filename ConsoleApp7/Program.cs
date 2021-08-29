using System;

namespace ConsoleApp7
{
    class Program
    {
        

        static void Main(string[] args)
        {
            while (true)
            {
                int activePlayer = 1;
                BoardManager Board = new BoardManager();
                UserInput Input = new UserInput();
                WinChecker win = new WinChecker();

                Game(Board, Input, win, activePlayer);
            }
            
        }

        static void Game(BoardManager Board, UserInput Input, WinChecker Win, int activePlayer)
        {
            while (true)
            {
                Board.Render();
                int fieldEntered = Input.Load(activePlayer, Board.Get());
                Board.Modify(activePlayer, fieldEntered);

                if (Win.Check(activePlayer, Board.Get()))
                {
                    Console.WriteLine("\nCongratulations player {0}, you are winner!", activePlayer);
                    Console.WriteLine("To play again pres enter");
                    Console.ReadLine();
                    break;
                }



                if (activePlayer == 1)
                {
                    activePlayer = 2;
                }
                else
                {
                    activePlayer = 1;
                }
            }
        }
    }
}
