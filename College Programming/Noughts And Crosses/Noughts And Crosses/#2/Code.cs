using System;
using System.Collections.Generic;
using System.IO;

namespace Noughts_And_Crosses.Noughts_And_Crosses
{
    class Program
    {

        // Skeleton program code for the AQA Comp1 Summer 2010 examination 
        // this code should be used in conjunction with the Preliminary 
        // materials written by the AQA COMP1 Programmer Team developed in 
        // the Visual Studio C# Express 2008 programming environment

        private static char[,] _board = new char[4, 4];
        private static string _playerOneName;
        private static string _playerTwoName;
        private static float _playerOneScore;
        private static float _playerTwoScore;
        private static int _x;
        private static int _y;
        private static bool _validMove;
        private static int _noOfMoves;
        private static bool _gameHasBeenWon;
        private static bool _gameHasBeenDrawn;
        private static char _startingSymbol;
        private static char _startSymbol;
        private static char _playerOneSymbol;
        private static char _playerTwoSymbol;
        private static char _answer;

        private static bool _ai;

        private static void LogLeaderboards()
        {
            Dictionary<string, int> winners = GetWinners();

            foreach (KeyValuePair<string, int> set in winners)
            {
                Console.WriteLine("{0}: {1}", set.Key, set.Value);
            }
        }

        private static Dictionary<string, int> GetWinners()
        {

            if (!File.Exists(@".\leaderboards.txt"))
            {
                File.CreateText(@".\leaderboards.txt");
                return new Dictionary<string, int>();
            }

            Dictionary<string, int> scores = new Dictionary<string, int>();
            string[] names = File.ReadAllText(@".\leaderboards.txt").Split('\n');

            foreach (string name in names)
            {
                if (scores.ContainsKey(name))
                {
                    scores[name] += 1;
                }
                else
                {
                    scores.Add(name, 1);
                }

            }

            return scores;
        }

        private static void LogScore(string name)
        {
            if (!File.Exists(@".\leaderboards.txt"))
            {
                File.CreateText(@".\leaderboards.txt");
            }

            File.AppendAllText(@".\leaderboards.txt", name + '\n');
        }

        private static string GetName(string request)
        {
            bool loopNameReq = true;
            string name = "";
            while (loopNameReq)
            {
                Console.Write(request + ": ");
                name = Console.ReadLine();

                if (name != null && (name.Equals(_playerOneName, StringComparison.Ordinal) ||
                                     name.Equals(_playerTwoName, StringComparison.Ordinal)))
                {
                    Console.WriteLine("Invalid name");
                }
                else if (name != null && name.Length < 2)
                {
                    Console.WriteLine("Please make sure the length of the name is bigger or equal to 2 character");

                }
                else loopNameReq = false;
            }
            return name;

        }

        private static void IntGetRandomMove(out int x, out int y)
        {
            var r = new Random();
            x = r.Next(3) + 1;
            y = r.Next(3) + 1;

        }

        private static void Main()
        {

            LogLeaderboards();

            bool runAgainstComputerCheck = true;
            while (runAgainstComputerCheck)
            {
                Console.Write("Would you like to play against a computer: ");
                var answer = Console.ReadKey().KeyChar;

                switch (answer)
                {
                    case 'Y':
                    case 'y':
                        runAgainstComputerCheck = false;
                        _ai = true;
                        break;
                    case 'N':
                    case 'n':
                        runAgainstComputerCheck = false;
                        _ai = false;
                        break;
                }
                Console.WriteLine("\n");
            }

            _playerOneName = GetName("What is the name of player one? ");

            if (!_ai)
            {
                _playerTwoName = GetName("What is the name of player two? ");
            }

            Console.WriteLine();
            _playerOneScore = 0;
            _playerTwoScore = 0;
            do   // Choose player one's symbol
            {
                Console.WriteLine(_playerOneName + " what symbol do you wish to use, X or O?");
                _playerOneSymbol = char.Parse(Console.ReadLine());
                Console.WriteLine();
                if (_playerOneSymbol != 'X' && _playerOneSymbol != 'O')
                {
                    Console.WriteLine("Symbol to play must be uppercase X or O");
                    Console.WriteLine();
                }
            } while (_playerOneSymbol != 'X' && _playerOneSymbol != 'O');
            if (_playerOneSymbol == 'X')
                _playerTwoSymbol = 'O';
            else
                _playerTwoSymbol = 'X';
            _startSymbol = GetWhoStarts();
            do  // Play a game
            {
                _noOfMoves = 0;
                _gameHasBeenDrawn = false;
                _gameHasBeenWon = false;
                ClearBoard(ref _board);
                Console.WriteLine();
                DisplayBoard(_board);
                if (_startSymbol == _playerOneSymbol)
                    Console.WriteLine(_playerOneName + " starts playing " + _startSymbol.ToString());
                else
                    Console.WriteLine(_playerTwoName + " starts playing " + _startSymbol.ToString());
                Console.WriteLine();
                _startingSymbol = _startSymbol;
                do   // Play until a player wins or the game is drawn
                {
                    do // Get a valid move
                    {

                        if ((_startingSymbol == _playerOneSymbol)) // ?
                        {
                            GetMoveCoordinates(out _x, out _y);
                        }
                        else
                        {
                            IntGetRandomMove(out _x, out _y);
                        }

                        _validMove = CheckValidMove(_x, _y, _board);
                        if (!_validMove)
                            Console.WriteLine("Coordinates invalid, please try again");

                    } while (!_validMove);



                    _board[_x, _y] = _startingSymbol;
                    DisplayBoard(_board);
                    _gameHasBeenWon = CheckXorOHasWon(_board);
                    _noOfMoves++;
                    if (!_gameHasBeenWon)
                    {
                        if (_noOfMoves == 9)   // Check if maximum number of
                            // allowed moves has been reached
                            _gameHasBeenDrawn = true;
                        else
                        {
                            if (_startingSymbol == 'X')
                                _startingSymbol = 'O';

                            else
                                _startingSymbol = 'X';
                        }
                    }
                } while (!_gameHasBeenWon && !_gameHasBeenDrawn);
                if (_gameHasBeenWon)   // Update scores and display results
                {
                    if (_playerOneSymbol == _startingSymbol)
                    {
                        Console.WriteLine(_playerOneName + " congratulations you win!");
                        LogScore(_playerOneName);
                        _playerOneScore++;
                    }
                    else
                    {
                        Console.WriteLine(_playerTwoName + " congratulations you win!");
                        LogScore(_playerTwoName);
                        _playerTwoScore++;
                    }
                }
                else
                    Console.WriteLine("A draw this time!");
                Console.WriteLine();
                Console.WriteLine(_playerOneName + ", your score is: " + _playerOneScore);
                Console.WriteLine(_playerTwoName + ", your score is: " + _playerTwoScore);
                Console.WriteLine();
                if (_startSymbol == _playerOneSymbol)
                    _startSymbol = _playerTwoSymbol;
                else
                    _startSymbol = _playerOneSymbol;
                Console.WriteLine("Another game Y/N? ");
                _answer = char.Parse(Console.ReadLine());
            } while (_answer == 'Y' && _answer == 'y');
        }
        // end Main

        public static void DisplayBoard(char[,] board)
        {
            int row;

            Console.WriteLine("  | 1 2 3 ");
            Console.WriteLine("--+-------");
            for (row = 1; row <= 3; row++)
            {
                Console.Write(row + " | ");
                int column;
                for (column = 1; column <= 3; column++)
                {
                    Console.Write(board[column, row] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        } // end DisplayBoard

        private static void ClearBoard(ref char[,] board)
        {
            int row;

            for (row = 1; row <= 3; row++)
            {
                for (var column = 1; column <= 3; column++)
                {
                    board[column, row] = ' ';
                }
            }
        }  // end ClearBoard

        private static void GetMoveCoordinates(out int xinate, out int yinate)
        {
            Console.Write("Enter x coordinate: ");
            xinate = int.Parse(Console.ReadLine());
            Console.Write("Enter y coordinate: ");
            yinate = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }  // end of GetMoveCoordinates

        private static bool CheckValidMove(int xinate, int yinate, char[,] board)
        {
            return board[_x, _y] != ' ' && (xinate >= 1 || xinate <= 3) && (yinate >= 1 || yinate <= 3);
        }  // end CheckValidMove

        private static bool CheckXorOHasWon(char[,] board)
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

            row = 0;
            for (int xy = 1; xy <= 3; xy++)
            {
                if (board[xy, xy] != ' ')
                {
                    row++;
                }
            }

            if (row == 3)
            {
                xorOHasWon = true;
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
                xorOHasWon = true;
            }

            return xorOHasWon;
        }  // end of CheckXOrOHasWon

        private static char GetWhoStarts()
        {
            char whoStarts;
            Random objRandom = new Random();
            int randomNo = objRandom.Next(100);
            if (randomNo % 2 == 0)
                whoStarts = 'X';
            else
                whoStarts = 'O';
            return whoStarts;
        }  // end of GetWhoStarts
    }
}
