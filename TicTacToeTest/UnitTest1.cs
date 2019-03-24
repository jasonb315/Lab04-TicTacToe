using Lab04_TicTacToe.Classes;
using System;
using Xunit;

//Test to confirm that the position the player inputs correlates to the correct index of the array
//One other “unique” test of your own

namespace Lab04_TicTacToe
{
    public class UnitTests
    {
        [Fact]
        public void TestWinX()
        {
            Board testBoard = new Board();
            string[,] winBoard = new string[,]
            {
            {"X", "2", "3"},
            {"4", "X", "6"},
            {"7", "8", "X"},
            };
            testBoard.GameBoard = winBoard;


            Player player1 = new Player
            {
                Name = "p1",
                Marker = "X",
                IsTurn = true
            };

            Player player2 = new Player
            {
                Name = "p2",
                Marker = "O",
                IsTurn = false
            };

            Game actualGame = new Game(player1, player1);
            actualGame.Board = testBoard;

            bool win = actualGame.CheckForWinner(testBoard);

            Assert.True(win);

        }

        [Fact]
        public void TestWinO()
        {
            Board testBoard = new Board();
            string[,] winBoard = new string[,]
            {
            {"X", "2", "3"},
            {"O", "O", "O"},
            {"7", "8", "X"},
            };
            testBoard.GameBoard = winBoard;


            Player player1 = new Player
            {
                Name = "p1",
                Marker = "X",
                IsTurn = true
            };

            Player player2 = new Player
            {
                Name = "p2",
                Marker = "O",
                IsTurn = false
            };

            Game actualGame = new Game(player1, player1);
            actualGame.Board = testBoard;

            bool win = actualGame.CheckForWinner(testBoard);

            Assert.True(win);

        }

        [Fact]
        public void PlayerSwitch()
        {
            Player player1 = new Player
            {
                Name = "p1",
                Marker = "X",
                IsTurn = true
            };

            Player player2 = new Player
            {
                Name = "p2",
                Marker = "O",
                IsTurn = false
            };

            Game actualGame = new Game(player1, player2);

            Assert.True(actualGame.PlayerOne.IsTurn);
            Assert.False(actualGame.PlayerTwo.IsTurn);

            actualGame.SwitchPlayer();

            Assert.False(actualGame.PlayerOne.IsTurn);
            Assert.True(actualGame.PlayerTwo.IsTurn);

        }
    }
}
