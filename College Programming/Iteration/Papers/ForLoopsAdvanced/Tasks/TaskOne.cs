using Layout;

namespace Iteration.Papers.ForLoopsAdvanced.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Task\n" +
                                "Produce a program to work out the average of any number of sales figures that are " +
                                "entered by the user.\n" +
                                "Approach\n" +
                                "- The user is initially asked how many sales figures they want to enter.\n" +
                                "- The program loops the specified number of times.\n" +
                                "- Each time around the loop the program asks the user to enter the specified sales figures\n" +
                                "- The latest sales figures are added to running total\n" +
                                "- Once the user finishes entering, an average is produced and output\n" +
                                "This is what the output should look like:\n" +
                                "Please specify how many sales figures you have to enter: \n" +
                                "4\n" +
                                "Please enter sales figures number: 1\n" +
                                "14.00\n" +
                                "Please enter sales figures number: 2\n" +
                                "15.00\n" +
                                "Please enter sales figures number: 3\n" +
                                "16.50\n" +
                                "Please enter sales figures number: 4\n" +
                                "14.50\n" +
                                "\n" +
                                "The average salesfigure is: £15.00\n" +
                                "\n" +
                                "Extensions\n" +
                                "- Format  the average as a currency\n" +
                                "- Output the highest sales figure\n" +
                                "- Output the lowest sale figure"
            , "For Loops Advanced") {}
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}