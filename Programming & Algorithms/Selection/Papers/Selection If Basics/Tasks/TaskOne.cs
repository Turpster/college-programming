using System;
using Layout;

namespace Selection.Papers.Selection_If_Basics.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that asked for the user to enter a Positive number. If the User " +
                                "enters a Negative number the program will display the message \"That is not a " +
                                "positive number\".", "Task One") {}
        
        public override void Run()
        {
            int number = Utils.AskUserInteger("Enter a number");
            
            if (number > 0) Console.WriteLine("That is a positive number");
            else if (number == 0) Console.WriteLine("It is both a positive and negative number");
            else Console.WriteLine("That is not a positive number");
        }
    }
}