using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Calculations.Tasks
{
    public class TaskFive : Task
    {
        public TaskFive() : base("Ask the user to enter the radius, r, of a circle. Your program should display the " +
                                 "area and circumference of this circle.\n" +
                                 "Pi = 3.1415\n" + 
                                 "Area of Circle = \u03C0 * r^2\n" + 
                                 "Circumference of a Circle = 2 * \u03C0 * r"
            , "Task Five")
        {}

        public override void Run()
        {
            double r = Utils.AskUserDouble("Please enter the radius of the circle");
            Console.WriteLine("Area of circle: {0}\n" +
                              "Circumference of circle: {1}", 
                Math.PI * Math.Pow(r, 2),
                2 * Math.PI * r
                );
        }
        
    }
}