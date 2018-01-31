using System;
using System.Collections.Generic;
using System.Drawing;


namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
             ArrayList<Point> snake = ArrayList<>();
            bool gameOn = false;
            int X = 30;
            int Y = 15;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetWindowSize(60, 30);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight);
            Console.SetCursorPosition(40, 20);
            Console.WriteLine("fesfesf");
            Console.ReadKey();
            Console.WriteLine("press any key to start the game");
            
            gameOn = true;
            
            while (gameOn == true)
            {
                Console.Clear();
                Console.SetCursorPosition(X, Y);
                Console.WriteLine("grdgf");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if(keyInfo.Key == ConsoleKey.Escape)
                {
                    gameOn = false;
                }else if(keyInfo.Key == ConsoleKey.UpArrow)
                {
                    Y--;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    Y++;
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    X--;
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    X++;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(Console.BufferWidth / 2, Console.BufferHeight / 2);
            Console.WriteLine("Game Over");
           Console.ReadKey();
        }
    }
}
