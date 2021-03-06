using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Calculations.Tasks
{
    public class TaskSeven : Task
    {
        public TaskSeven() : base("A “phone bill” is made up of £20 for being connected to a network, £10 for broadband " +
                                  "and then 10p for each call made." +
                                  "Write a program that asks for the number of calls and then calculates the phone bill.",
            "Task Seven")
        {}

        public override void Run()
        {
            int numCalls = Utils.AskUserInteger("Number of Calls");
            
            Console.WriteLine("Phone Bill equates to £{0}.", 0.10 * numCalls);
        }
        
    }
}