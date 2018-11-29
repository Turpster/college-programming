using System;
using Layout;

namespace Iteration.Papers.StringFunctionsOne.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("2)Write a program that asks the user to enter a password. If the password is less " +
                                "than 8 characters long or more than 12 characters long, then output a message: " +
                                "Password is invalid, and then loop around allowing the user to enter again."
            , "Task Two") {}
        
        public override void Run()
        {
            string password = Utils.AskUserString("Please input a password");

            if (!(password.Length >= 8 && password.Length <= 12))
            {
                Console.WriteLine("Password is invalid, and then loop around allowing the user to enter again.");
                Run();
            }
        }
    }
}