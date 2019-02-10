using System;
using Layout;

namespace Selection.Papers.SelectionPaper.Tasks
{
    public class TaskEight : Task
    {
        public TaskEight() : base("- Adapt the program to allow the user to enter an expression that contains numbers " +
                                  "of any length (real types).\n" +
                                  "    12-3\n" +
                                  "    123/4\n" +
                                  "    1.23*4.567\n" +
                                  "- The expression should still be checked to ensure that it contains a valid " +
                                  "operation character and then either evaluate and display the answer or display an " +
                                  "error message.\n" +
                                  "- The output should be given as an equation, e.g." +
                                  "    12-3=9\n" +
                                  "- The answer should be formatted to a maximum of 3 decimal places.\n",
            "Exercise 2 - Extension"){}

        public override void Run()
        {
            Console.WriteLine("Re-Running Task Seven as it supports same functionality already");
            new TaskSeven().Run();
        }
    }
}