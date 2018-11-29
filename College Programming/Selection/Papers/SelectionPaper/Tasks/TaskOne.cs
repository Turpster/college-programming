using System;
using Layout;

namespace Selection.Papers.SelectionPaper.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program to request a secret password and either grant or deny access", 
            "Program 2A - Password") {}

        public override void Run()
        {
            string password = Utils.AskUserString("Password");

            Console.WriteLine(password == "TotallySecurePassword123" ? "Access Granted" : "Access Denied");
        }
    }
}