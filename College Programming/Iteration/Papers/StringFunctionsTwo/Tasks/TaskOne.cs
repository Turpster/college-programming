using Layout;

namespace Iteration.Papers.StringFunctionsTwo.Tasks
{
    public class TaskOne : Task
    { 
        public TaskOne() : base(
            "Produce a program to accept a date from a person in the following format dd/mm/yyyy.\n" +
            "Using the skills that you have learnt with string manipulation and Selection Statements make a program " +
            "that will do the following:\n" +
            "Output the date in the form: 	23rd October 2003, 14th July 2004,\n" +
            "1st November 2006\n" +
            "To achieve this: \n" +
            "- Accept the date as a new variable (Data Type – String)\n" +
            "  NB You cannot use Date as a variable name as it is the name of a function\n" +
            "- Use text manipulation functions to separate the day, month and year (e.g. SubString)\n" +
            "- Use a SWITCH or IF statement to determine the month name\n" +
            "- Use a SWITCH or CASE statement to determine if the day would end in st, th, rd, nd\n" +
            "- Concatenate the day with the appropriate ending\n" +
            "- Output this with the appropriate month and year.\n" +
            "Extras\n" +
            "- Add a check to make sure the date is valid, (i.e. has the correct number of days in the month),if not then output a message box to alert the user.\n" +
            "- Can you incorporate leap year validation?\n" +
            "- Ensure that if the day starts with a zero that this is removed.\n" +
            "- Check to ensure that the entered date has the correct number of characters (i.e. has been entered in the correct format of dd/mm/yyyy)\n" +
            "- Test your programme thoroughly with a variety of suitable inputs.\n" +
            "- Test your programme thoroughly with a variety of suitable inputs.\n" +
            "\n" + 
            "Please enter a date in format dd/mm/yyyy:  18112008\n" +
            "Date is invalid." + 
            "Please enter a date in format dd/mm/yyyy:  18/11/2008\n" +
            "\n" +
            "The date is: 18th November 2008"
            , "Paper Task") {}
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}