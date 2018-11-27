using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_2.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Write a program to help with journey planning.  The program should input the " +
                                  "starting time and the time taken, both in hours and minutes.  It should output " +
                                  "the finishing time (using a 12 hour clock).  The hours and minutes should be " +
                                  "entered separately as in the console session below.  Hint: Use six variables, two " +
                                  "for each time (one variable for the hours, one for the minutes).  Use integer " +
                                  "division and modulus operations.",
            "Task Three")
        {}

        public override void Run()
        {
            DateTime startDateTime = Utils.AskUserDateTime("When did you start your journey");
            DateTime endDateTime = Utils.AskUserDateTime("When did your journey end");
            TimeSpan totalTime = endDateTime - startDateTime;
            
            Console.Write("You started at {0:d} and ended at {1:d}, you were out there for {2} hours, {3} " +
                              "minutes and {4} seconds", startDateTime, endDateTime, totalTime.TotalHours, 
                totalTime.Minutes, totalTime.Seconds);

            Console.Write(totalTime.TotalHours >= 2 ? "!" : "."); 
        }
        
    }
}