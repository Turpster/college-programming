using System;
using System.Linq;

namespace NoughtsAndCrosses
{
    class Program
    {

        // Skeleton program code for the AQA Comp1 Summer 2010 examination 
        // this code should be used in conjunction with the Preliminary 
        // materials written by the AQA COMP1 Programmer Team developed in 
        // the Visual Studio C# Express 2008 programming environment

        public static char[,] Board = new char[4, 4];
        public static string PlayerOneName;
        public static string PlayerTwoName;
        public static float PlayerOneScore;
        public static float PlayerTwoScore;
        public static int XCoord;
        public static int YCoord;
        public static bool ValidMove;
        public static int NoOfMoves;
        public static bool GameHasBeenWon;
        public static bool GameHasBeenDrawn;
        public static char CurrentSymbol;
        public static char StartSymbol;
        public static char PlayerOneSymbol;
        public static char PlayerTwoSymbol;
        public static char Answer;

        
        public static string GetName(string request)
        {
            string name = "";
            bool GetName = true;
            while(GetName)
            {
                Console.Write(request + ": ");
                name = Console.ReadLine();
                if (!(name.Length >= 2))
                {
                    Console.WriteLine("Name has to be 2 or more letters.");
                    GetName = true;
                }
                else
                {
                    GetName = false;
                }
                if (PlayerOneName.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    Console.WriteLine("Cannot have the same name twice");
                    GetName = true;
                }
                else
                {
                    GetName = false;
                }
            }

            return name;
        }

        public static void Main(string[] args)
        {
            PlayerOneName = GetName("What is the name of player one?");
            PlayerTwoName = GetName("What is the name of player two?");

            Console.WriteLine();
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
            do   // Choose player one's symbol
            {
                Console.WriteLine(PlayerOneName + " what symbol do you wish to use, X or O?");
                PlayerOneSymbol = char.Parse(Console.ReadLine());
                Console.WriteLine();
                if (PlayerOneSymbol != 'X' && PlayerOneSymbol != 'O')
                {
                    Console.WriteLine("Symbol to play must be uppercase X or O");
                    Console.WriteLine();
                }
            } while (PlayerOneSymbol != 'X' && PlayerOneSymbol != 'O');
            if (PlayerOneSymbol == 'X')
                PlayerTwoSymbol = 'O';
            else
                PlayerTwoSymbol = 'X';
            StartSymbol = GetWhoStarts();
            do  // Play a game
            {
                NoOfMoves = 0;
                GameHasBeenDrawn = false;
                GameHasBeenWon = false;
                ClearBoard(ref Board);
                Console.WriteLine();
                DisplayBoard(Board);
                if (StartSymbol == PlayerOneSymbol)
                    Console.WriteLine(PlayerOneName + " starts playing " + StartSymbol.ToString());
                else
                    Console.WriteLine(PlayerTwoName + " starts playing " + StartSymbol.ToString());
                Console.WriteLine();
                CurrentSymbol = StartSymbol;
                do   // Play until a player wins or the game is drawn
                {
                    do // Get a valid move
                    {
                        GetMoveCoordinates(ref XCoord, ref YCoord);
                        ValidMove = CheckValidMove(XCoord, YCoord, Board);
                        if (!ValidMove)
                            Console.WriteLine("Coordinates invalid, please try again");
                    } while (!ValidMove);
                    Board[XCoord, YCoord] = CurrentSymbol;
                    DisplayBoard(Board);
                    GameHasBeenWon = CheckXorOHasWon(Board);
                    NoOfMoves++;
                    if (!GameHasBeenWon)
                    {
                        if (NoOfMoves == 9)   // Check if maximum number of
                            // allowed moves has been reached
                            GameHasBeenDrawn = true;
                        else
                        {
                            CurrentSymbol = CurrentSymbol == 'X' ? 'O' : 'X';
                        }
                    }
                } while (!(GameHasBeenWon && GameHasBeenDrawn));
                if (GameHasBeenWon)   // Update scores and display results
                {
                    if (PlayerOneSymbol == CurrentSymbol)
                    {
                        Console.WriteLine(PlayerOneName + " congratulations you win!");
                        PlayerOneScore++;
                    }
                    else
                    {
                        Console.WriteLine(PlayerTwoName + " congratulations you win!");
                        PlayerTwoScore++;
                    }
                }
                else
                    Console.WriteLine("A draw this time!");
                Console.WriteLine();
                Console.WriteLine(PlayerOneName + ", your score is: " + PlayerOneScore);
                Console.WriteLine(PlayerTwoName + ", your score is: " + PlayerTwoScore);
                Console.WriteLine();
                if (StartSymbol == PlayerOneSymbol)
                    StartSymbol = PlayerTwoSymbol;
                else
                    StartSymbol = PlayerOneSymbol;
                Console.WriteLine("Another game Y/N? ");
                Answer = Console.ReadKey().KeyChar;
            } while (Answer != 'N' && Answer != 'n');
        } // end Main

        public static void DisplayBoard(char[,] Board)
        {
            int Row;
            int Column;

            Console.WriteLine("  | 1 2 3 ");
            Console.WriteLine("--+-------");
            for (Row = 1; Row <= 3; Row++)
            {
                Console.Write(Row + " | ");
                for (Column = 1; Column <= 3; Column++)
                {
                    Console.Write(Board[Column, Row] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        } // end DisplayBoard

        public static void ClearBoard(ref char[,] Board)
        {
            int Row;
            int Column;

            for (Row = 1; Row <= 3; Row++)
            {
                for (Column = 1; Column <= 3; Column++)
                {
                    Board[Column, Row] = ' ';
                }
            }
        }  // end ClearBoard

        public static void GetMoveCoordinates(ref int xCoordinate, ref int YCoordinate)
        {
            Console.Write("Enter x coordinate: ");
            xCoordinate = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate: ");
            YCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }  // end of GetMoveCoordinates

        public static bool CheckValidMove(int x, int y, char[,] Board)
        {
            bool ValidMove = true;

            var range = Enumerable.Range(1, 3);
            if (range.Contains(x) && range.Contains(y)) // Check X coordinate is valid
                ValidMove = false;
            
            else if (Board[x, y] != ' ')
            {
                ValidMove = false;
            }

            return ValidMove;
        }  // end CheckValidMove

        public static bool CheckXorOHasWon(char[,] board)
        {
            bool xorOHasWon;
            int row;
            int column;

            xorOHasWon = false;
            for (column = 1; column <= 3; column++)
            {
                if (board[column, 1] == board[column, 2]
                        && board[column, 2] == board[column, 3]
                        && board[column, 2] != ' ')
                    xorOHasWon = true;
            }
            for (row = 1; row <= 3; row++)
            {
                if (board[1, row] == board[2, row]
                        && board[2, row] == board[3, row]
                        && board[2, row] != ' ')
                    xorOHasWon = true;
            }

            
            for (int xy = 1; xy <= 3; xy+=1)
            {
                if (board[xy, xy] != ' ')
                {
                    xorOHasWon = true;
                }
            }
            for (int y = 1; y <= 3; y += 1)
            {
                for (int x = 3; 1 >= 1; x -= 1)
                {
                    if (board[x, y] != ' ')
                    {
                        xorOHasWon = true;
                    }
                }
            }

            return xorOHasWon;
        }  // end of CheckXOrOHasWon

        public static char GetWhoStarts()
        {
            char WhoStarts;
            Random objRandom = new Random();
            int RandomNo = objRandom.Next(100);
            if (RandomNo % 2 == 0)
                WhoStarts = 'X';
            else
                WhoStarts = 'O';
            return WhoStarts;
        }  // end of GetWhoStarts
    }
}
