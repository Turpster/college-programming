using System;
using Layout;

namespace Selection.Papers.SelectionPaper.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("- Write a program to evaluate whether or not an input year is a leap year.",
            "Program 2A - Leap Years") {}

        public override void Run()
        {
            Console.WriteLine(DateTime.IsLeapYear(Utils.AskUserInteger("Leap Year")) ? "Is a leap year." : "Is not a leap year.");
        }
    }
}