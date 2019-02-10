using System;
using Layout;

namespace Selection.Papers.Selection_If_Else.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that allows the user to enter two numbers – Number 1 and Number 2. " +
                                "The program will tell the user which of the two numbers is Larger or whether they " +
                                "are both the same.", 
            "Task One") {}
        
        public override void Run()
        {
            int[] nums = { Utils.AskUserInteger("Number 1"), Utils.AskUserInteger("Number 2") };
            if (nums[0] == nums[1])
            {
                Console.WriteLine("Both are equal.");
            }
            else
            {
                Console.WriteLine(nums[0] > nums[1] ? "Number 1 is bigger than Number 2" : "Number 2 is bigger than Number 1");
            }
        }
    }
}