using System;
using System.Data;
using Layout;

namespace Selection.Papers.Exercises_Two.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Produce a program to accept a date from a person:\n" +
                                "  - Enter Day\n" +
                                "  - Enter Month\n" +
                                "  - Enter year\n" + 
                                "Using the skills that you have learnt with If Statements and Switch statements make " +
                                "a program that will do the following:" +
                                "Output the date in the form: 23rd October 2006, 14th July 2008, \n" +
                                "1st November 2007\n" + 
                                "To achieve this" + 
                                "- Use a SWITCH statement to determine the month name\n" +
                                "- Check if the day would end in st, th, rd, nd\n" +
                                "- Concatenate the day with the appropriate ending (using + symbol)\n" +
                                "  -i.e. concatenate means join together console.writeline(day + ending + ....)\n" +
                                "- Output this with the appropriate month and year.\n" +
                                "Extras: \n" +
                                "- Add a check to make sure the date is valid, (i.e. has the correct number of days " +
                                "in the month, is a month between 1 and 12 etc),if not then output a message box to alert the user.\n" +
                                "- Test your programme thoroughly with a variety of suitable inputs.",
            "Paper Task") {}

        
        public override void Run()
        {
            DateTime date = Utils.AskUserDate("Date");
            Console.WriteLine("Date: {0}{1} {2:MMMM yyyy}", date.Day, Utils.GetDaySuffix(date.Day), date);
        }
    }
}