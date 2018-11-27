using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Calculations.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("Ask the user to enter one side of a square and your program should display the " +
                                "area of the square.",
            "Task Two")
        {}

        public override void Run()
        {
            double side = Utils.AskUserDouble("Please enter the size of one side of the square");
            Console.WriteLine("Area of Square: ", side*2);
        }
        
    }
}