﻿using System;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            PlayGame();
        }

        static void PlayGame()
        {
            Classes.Board board = new Classes.Board();

            board.DisplayBoard();

            // TODO: Setup your game here. Create an introduction. 
            // Create your players, and instantiate your Game class. 
            // output to the console the winner
        }
    }
}
