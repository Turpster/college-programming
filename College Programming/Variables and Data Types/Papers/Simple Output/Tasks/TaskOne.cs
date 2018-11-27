using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Output.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base(
            "Write a program that displays your name on one line and your age on another.",
            "Task One")
        {}

        public override void Run()
        {
            string name = Utils.AskUserString("Please enter your name");
            int age = Utils.AskUserInteger("Please enter your age");
            
            Console.WriteLine("Name: {0}\n" +
                              "Age: {1}", name, age);
        }
        
    }
}