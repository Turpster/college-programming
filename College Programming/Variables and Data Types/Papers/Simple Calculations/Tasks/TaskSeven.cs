using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Calculations.Tasks
{
    public class TaskSix : Task
    {
        public TaskSix() : base("A takeaway shop sells portions of chicken and chips for £4.25 each." +
                                "Write a program that asks for how many portions have been sold and then prints out " +
                                "the total amount of money taken.\n"
            , "Task Six") {}

        public override void Run()
        {
            int portions = Utils.AskUserInteger("Please enter how many portions have been sold");
            
            Console.WriteLine("that equates to £{0}.", portions * 4.25);
        }
    }
}