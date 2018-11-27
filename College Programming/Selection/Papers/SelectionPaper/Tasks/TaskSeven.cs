using Layout;

namespace Selection.Papers.SelectionPaper.Tasks
{
    public class TaskSeven : Task
    {
        public TaskSeven() : base("- Write a console program to function as a basic calculator – supporting " +
                                  "operations * / + -\n" +
                                  "- The program should allow a single digit expression to be entered without spaces, " +
                                  "e.g.\n" +
                                  "    9+3\n" +
                                  "    7*4\n" +
                                  "- The expression should be checked to ensure that it contains a valid operation and " +
                                  "either evaluate and display the answer or display an error message.\n" +
                                  "- The output should be given as an equation, e.g.\n" +
                                  "    9+3=12\n" +
                                  "- The answer should be formatted to a maximum of 3 decimal places.",
            "Exercise 2 – String Calculator"){}

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}