using System;
using Layout;

namespace Selection.Papers.Selection_If_Else.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Write a program to take in two football scores. A home score and an away score. " +
                                  "Using the two scores, output the appropriate message of:\n" +
                                  "Home Win (if the home score is larger than the away score)\n" +
                                  "Away Win (if the away score is larger than the home score)\n" +
                                  "Score Draw (if both teams drew with a Score)\n" +
                                  "No Score Draw (if neither team scored a goal)", 
            "Task Three") {}
        
        public override void Run()
        {
            int[] nums = { Utils.AskUserInteger("Home"), Utils.AskUserInteger("Away") };
            if (nums[0] + nums[1] == 0)
            {
                Console.WriteLine("No Score Draw");
            }
            else if (nums[0] == nums[1])
            {
                Console.WriteLine("Score Draw");
            }
            else
            {
                Console.WriteLine(nums[0] > nums[1] ? "Home Win" : "Away Win");
            }
        }
    }
}