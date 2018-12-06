using System;

namespace Noughts_And_Crosses.Noughts_And_Crosses
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

        public static bool AI;

        public static string GetName(string request)
        {
            bool LoopNameReq = true;

            while (LoopNameReq)
            {
                Console.Write(request + ": ");
                string name = Console.ReadLine();

                if (!(name.Equals(PlayerOneName, StringComparison.Ordinal) ||
                      name.Equals(PlayerTwoName, StringComparison.Ordinal)))
                {
                    Console.WriteLine("Invalid name");
                }
                else if (name.Length < 2)
                {
                    Console.WriteLine("Please make sure the length of the name is bigger or equal to 2 character");
                }
                else
                {
                    return name;
                }
            }
        }

        static void intGetRandomMove(ref int XCoord, ref int YCoord)
        {
            Random r = new Random();
            XCoord = r.Next(3) + 1;
            YCoord = r.Next(3) + 1;

        }
        
        static void Main(string[] args)
        {

            bool runAgainstComputerCheck = true;
            while (runAgainstComputerCheck)
            {
                Console.Write("Would you like to play against a computer: ");
                char answer = Console.ReadKey().KeyChar;

                if (answer == 'Y' || answer == 'y')
                {
                    runAgainstComputerCheck = false;
                    AI = true;
                }
                else if (answer == 'N' || answer == 'n')
                {
                    runAgainstComputerCheck = false;
                    AI = false;
                }
            }

            PlayerOneName = GetName("What is the name of player one? ");

            if (!AI)
            {
                PlayerTwoName = GetName("What is the name of player two? ");
            }

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
                        
                        if ((CurrentSymbol == PlayerOneSymbol)) // ?
                        {
                            GetMoveCoordinates(ref XCoord, ref YCoord);
                        }
                        else
                        {
                            intGetRandomMove(ref XCoord, ref YCoord);
                        }
                        
                        ValidMove = CheckValidMove(XCoord, YCoord, Board);
                        if (!ValidMove)
                            Console.WriteLine("Coordinates invalid, please try again");
                        
                    } while (!ValidMove);

                    
                    
                    Board[XCoord, YCoord] = CurrentSymbol;
                    DisplayBoard(Board);
                    GameHasBeenWon = CheckXOrOHasWon(Board);
                    NoOfMoves++;
                    if (!GameHasBeenWon)
                    {
                        if (NoOfMoves == 9)   // Check if maximum number of
                            // allowed moves has been reached
                            GameHasBeenDrawn = true;
                        else
                        {
                            if (CurrentSymbol == 'X')
                                CurrentSymbol = 'O';
                            
                            else
                                CurrentSymbol = 'X';
                        }
                    }
                } while (!GameHasBeenWon && !GameHasBeenDrawn);
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
                Answer = char.Parse(Console.ReadLine());
            } while (Answer == 'Y' && Answer == 'y');
        } // end Main

        public static void DisplayBoard(char[,] Board)
        {
            int Row;
            int Column;

            Console.WriteLine("  | 1 2 3 ");
            Console.WriteLine("--+-------");
            for (Row = 1; Row <= 3; Row++)
            {
                Console.Write((Row).ToString() + " | ");
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

        public static void GetMoveCoordinates(ref int XCoordinate, ref int YCoordinate)
        {
            Console.Write("Enter x coordinate: ");
            XCoordinate = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate: ");
            YCoordinate = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }  // end of GetMoveCoordinates

        public static bool CheckValidMove(int XCoordinate, int YCoordinate, char[,] Board)
        {
            return Board[XCoord, YCoord] != ' ' && (XCoordinate >= 1 || XCoordinate <= 3) && (YCoordinate >= 1 || YCoordinate <= 3) && Board[XCoordinate, YCoordinate] == ' ';
        }  // end CheckValidMove

        public static bool CheckXOrOHasWon(char[,] Board)
        {
            bool XOrOHasWon;
            int Row;
            int Column;

            XOrOHasWon = false;
            for (Column = 1; Column <= 3; Column++)
            {
                if (Board[Column, 1] == Board[Column, 2]
                        && Board[Column, 2] == Board[Column, 3]
                        && Board[Column, 2] != ' ')
                    XOrOHasWon = true;
            }
            for (Row = 1; Row <= 3; Row++)
            {
                if (Board[1, Row] == Board[2, Row]
                        && Board[2, Row] == Board[3, Row]
                        && Board[2, Row] != ' ')
                    XOrOHasWon = true;
            }

            int row;
            row = 0;
            for (int xy = 1; xy <= 3; xy++)
            {
                if (Board[xy, xy] != ' ')
                {
                    row++;
                }
            }

            if (row == 3)
            {
                XOrOHasWon = true;
            }
           
            row = 0;
            for (int x = 3; x >= 1; x--)
            {
                for (int y = 1; y <= 3; y++)
                {
                    row++;
                }
            }

            if (row == 3)
            {
                XOrOHasWon = true;
            }

            return XOrOHasWon;
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
