using System;
using Layout;

namespace Selection.Papers.SelectionPaper.Tasks
{
    public class TaskSix : Task
    {
        public TaskSix() : base("Write a program that requests a character and then outputs either the reverse case " +
                                 "(e.g. a to A, Z to z) or a message stating that the input is not a character.",
            "Program 2D")
        {
        }

        public override void Run()
        {
            char chr = Utils.AskUserChar("Char");
            Console.WriteLine((char) (chr + (chr < 95 ? +32 : -32))); // 32 is the difference between upper and lower case characters
        }
    }
}