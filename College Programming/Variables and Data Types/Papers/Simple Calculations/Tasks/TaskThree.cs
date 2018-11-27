using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Calculations.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Ask the user to enter two sides of a rectangular field and your program should " +
                                  "display the area of the field and the length of fence to go round that field.",
            "Task Three")
        {}

        public override void Run()
        {
            double width = Utils.AskUserDouble("Please enter width");
            double height = Utils.AskUserDouble("Please enter height");
            
            Console.WriteLine("Area: {0}\n" +
                              "Perimeter: {1}", width * height, (width*2) + (height*2));
        }
        
    }
}