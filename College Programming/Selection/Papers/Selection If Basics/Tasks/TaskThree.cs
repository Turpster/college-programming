using System;
using System.Collections.Generic;
using System.Linq;
using Layout;
using Utils = Layout.Utils;

namespace Selection.Papers.Selection_If_Basics.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Two players of mini-golf enter their scores into a computer. The program will " +
                                  "determine which player is the winner by seeing whose score is the lowest. The " +
                                  "program should output a message in the following format\n" +
                                  "\"Hi Mary, you was the winner at Mini-Golf and beat Bob by 5 points\"\n" +
                                  "Hint:\n" +
                                  "You need to enter names for each player, you also need to work out the difference " +
                                  "of the two scores.", 
            "Task Three") {}
        
        public override void Run()
        {
            Player[] players = { new Player(), new Player() };

            Player highest = players[0];
            Player lowest = players[0];
            foreach (Player player in players)
            {
                highest = player.Score > highest.Score ? player : highest;
                lowest = player.Score < lowest.Score ? player : highest;
            }

            Console.WriteLine("Hi {0}, you was the winner at Mini-Golf and beat {1} by {2} points.", highest.Name, lowest.Name, highest.Score - lowest.Score);
        }
    }

    class Player
    {
        public readonly string Name;
        public readonly int Score;

        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public Player()
        {
            Name = Utils.AskUserString("Name");
            Score = Utils.AskUserInteger("Score");
        }
    }
}