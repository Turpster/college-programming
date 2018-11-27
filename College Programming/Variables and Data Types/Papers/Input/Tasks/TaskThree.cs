using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Input.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Write a program that displays a railway notice, similar to the one below. " +
                                  "The program must ask for a time (like 10:30 am) and put it at the end of the last " +
                                  "line:\n" +
                                  "Cleethorpes Railway wish to announce that\n" +
                                  "the Coastal Express will depart from platform\n" +
                                  "2 at X",
            "Task Three")
        {}

        public override void Run()
        {
            Console.Write("Time: ");
            string time = Console.ReadLine();
            Console.Write("Cleethorpes Railway wish to announce that\n" +
                          "the coastal express will depart from platform\n" +
                          "2 at {0}", time);
        }
        
    }
}