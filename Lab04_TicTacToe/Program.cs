using System;
using System.Threading;

namespace Lab04_TicTacToe
{
    class Program
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

        static void PlayGame()
        {
            //////////////////
            Console.ForegroundColor = ConsoleColor.Gray;
            string appName = "TickTackToe";
            string appVersion = "1.0.0";
            string appAuthor = "Jason Burns";
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ForegroundColor = ConsoleColor.White;
            string title = @"
 ____  __  __    ____  __   __  _ _     ____  __  ___ 
(_  _)(  )/ _)  (_  _)(  ) / _)( ) )   (_  _)/  \(  _)
  )(   )(( (_     )(  /__\( (_  )  \     )( ( () )) _)
 (__) (__)\__)   (__)(_)(_)\__)(_)\_)   (__) \__/(___)
                ";
            Console.Write(title);
            Thread.Sleep(100);
            Console.Clear();
            //////////////////


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
            

            // TODO: Setup your game here. Create an introduction. 
            // Create your players, and instantiate your Game class. 
            // output to the console the winner
        }
    }
}
