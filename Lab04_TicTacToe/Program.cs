using System;
using System.Threading;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PlayGame();

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exiting game.");
            }
        }

        /// <summary>
        ///     Greeting, player/game setup, play initiation, and win report.
        /// </summary>
        static void PlayGame()
        {
            //////////////////
            Console.ForegroundColor = ConsoleColor.Gray;
            string appName = "TickTackToe";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            

            Console.ForegroundColor = ConsoleColor.White;
            string title = @"
 _______ _____ _____   _______       _____   _______ ____  ______ 
|__   __|_   _/ ____| |__   __|/\   / ____| |__   __/ __ \|  ____|
   | |    | || |         | |  /  \ | |         | | | |  | | |__   
   | |    | || |         | | / /\ \| |         | | | |  | |  __|  
   | |   _| || |____     | |/ ____ \ |____     | | | |__| | |____ 
   |_|  |_____\_____|    |_/_/    \_\_____|    |_|  \____/|______|
                ";

            int color = 0;
            for (int i = 0; i < 7; i++)
            {
                if (color == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                if (color == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                if (color == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                if (color == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (color == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                if (color == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);
                Console.Write(title);
                color++;
                Thread.Sleep(400);
                Console.Clear();
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("Player one enter name: ");
            string p1 = Console.ReadLine();

            Classes.Player player1 = new Classes.Player
            {
                Name = p1,
                Marker = "X",
                IsTurn = true
            };

            Console.WriteLine("Player one enter name: ");
            string p2 = Console.ReadLine();

            Classes.Player player2 = new Classes.Player
            {
                Name = p2,
                Marker = "O",
                IsTurn = false
            };

            Console.Clear();
            Console.WriteLine("FIGHT!");

            Classes.Game game = new Classes.Game(player1, player2);

            Classes.Player winner = game.Play();

            if (!(winner is null))
            {
                Console.WriteLine($"{winner.Name} wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
