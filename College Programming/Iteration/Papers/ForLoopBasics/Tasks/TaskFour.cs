using System;
using System.Linq;
using Layout;

namespace Iteration.Papers.ForLoopBasics.Tasks
{
    public class TaskFour : Task
    {
        public TaskFour() : base("Produce a program that makes use of a For Loop and asks the user to type in ten " +
                                 "numbers. The ten numbers are totalled and the total displayed at the end of the " +
                                 "program.\n" +
                                 "Hint: \n" +
                                 "You only need one line and one variable for the user input\n" +
                                 "You need a variable to hold the running total\n", 
            "Task Four")
        {
        }

        public override void Run()
        {   
            int[] nums = new int[10];
            
            for (int i = 1; i <= 10; i++)
            {
                nums[i] = Utils.AskUserInteger("Value");
            }
            
            Console.Write("Sum: {0}.", nums.Sum());
        }
    }
}