using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Random_Number.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Write a program that generates 2 random numbers, the first should be a real " +
                                  "number displayed to 3 d.p. and the second should be an integer between 0 and 25",
            "Task Three")
        {}

        public override void Run()
        {
            var r = new Random();
            Console.WriteLine("Real (Probably going to be a big one): {0:0.000}", r.NextDouble() * Double.MaxValue);
            Console.WriteLine("Integer: {0}", r.Next(25));
        }
    }
}