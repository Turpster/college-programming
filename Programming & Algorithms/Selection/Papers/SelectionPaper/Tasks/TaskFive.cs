using System;
using Layout;

namespace Selection.Papers.SelectionPaper.Tasks
{
    public class TaskFive : Task
    {
        public TaskFive() : base("- Write a program to request the user’s full name in the format \"Surname,Forename\"" +
                                 "(e.g. \"Aardvark,Aaron\") and then greet the user by forename and state the length " +
                                 "of their surname (e.g. \"Hello Aaron. Your surname is 8 characters long.\")",
            "Program 2C - What’s in a name")
        {
        }

        public override void Run()
        {
            bool running = true;

            string[] nameSplit = Utils.AskUserNameAndSurname();
            
            Console.WriteLine("Hello {0}. Your surname is {1} characters long.", nameSplit[0], nameSplit[1].Length);
        }
    }
}