using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// Tic Tac Toe Gameboard states
		/// </summary>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        ///     Reads the Board to the user.
        /// </summary>
		public void DisplayBoard()
		{

            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                StringBuilder boardOut = new StringBuilder();
                StringBuilder boardBreak = new StringBuilder();


                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    boardOut.Append(GameBoard[i, j]);
                    if ( j < (GameBoard.GetLength(1)) - 1)
                    {
                        boardOut.Append(" | ");
                    }
                    boardBreak.Append("---");
                }

                Console.WriteLine(boardOut.ToString());
                if (i < (GameBoard.GetLength(1) - 1))
                {
                    Console.WriteLine(boardBreak);
                }
            }
		
		}
	}
}
