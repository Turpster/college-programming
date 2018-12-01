using System;
using Layout;

namespace Arrays.Papers.ArraysWorksheetThree.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("What would you do if you wanted to record car details for the years 2012 – 2015?\n"
            , "Task Four") {}
        
        public override void Run()
        {
            Console.WriteLine("What would you do if you wanted to record car details for the years 2012 – 2015?");
            
            Console.WriteLine("I would create a database with a table that required a unique identifier, preferably " +
                              "an integer, then I would store the details of the cars in separate rows whereas the " +
                              "entries will be added in columns which means the cars must have the data specified " +
                              "for the detail of a car.");
        }
    }
}