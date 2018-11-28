using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Calculations.Tasks
{
    public class TaskFour : Task
    {
        public TaskFour() : base("Ask the user to enter the Height and Layout of a triangle and your program should " +
                                 "display the area of the triangle.\n" +
                                "The formula to calculate the area of a triangle is base/2 * height",
            "Task Four")
        {}

        public override void Run()
        {
            double height = Utils.AskUserDouble("Please enter the height of the triangle");
            double width = Utils.AskUserDouble("Please enter the width of the base of the triangle");
            
            Console.WriteLine("Area of Triangle: {0}", (height * width) / 2);
        }
        
    }
}