using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Random_Number.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that generates and displays 2 random numbers. Use the FORMAT " +
                                "function to show these numbers to 2 decimal places", 
            "Task One")
        {}

        public override void Run()
        {
            Random r = new Random();
            
            Console.WriteLine("Random number is (Probably going to be a big one) {0:0.00}.", r.NextDouble() * Double.MaxValue);
        }
    }
}