using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Random_Number.Tasks
{
    public class TaskFour : Task
    {
        public TaskFour() : base("Write a program that generates a random number between 50 and 100.\n" +
                                 "HINT: a random number between 0 and 50, then add 50.",
            "Task Four")
        {}

        public override void Run()
        {
            var r = new Random();
            Console.WriteLine("Random Number: {0}", r.Next(50) + 50);
        }
        
    }
}