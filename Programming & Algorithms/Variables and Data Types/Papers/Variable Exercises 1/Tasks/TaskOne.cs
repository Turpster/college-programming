using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_1.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base(
            "Produce a program that allows you to enter your name and your year of birth (e.g. 1999). The program " +
            "will then output a message in the following format:\n" +
            "\" Hi Fred, you will be X yrs  old next year \"",
            "Task One")
        {}

        public override void Run()
        {
            string name = Utils.AskUserString("Name");
            int yearOfBirth = Utils.AskUserInteger("Year of age");
            Console.WriteLine("Hi {0}, you will be {1} yrs old next year", name, yearOfBirth);
        }
        
    }
}