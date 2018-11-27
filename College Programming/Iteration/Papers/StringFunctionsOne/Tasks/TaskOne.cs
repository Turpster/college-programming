using Layout;

namespace Iteration.Papers.StringFunctionsOne.Tasks
{
    public class TaskOne : Task
    { 
        public TaskOne() : base("1) Allow the user to enter some text into a variable, using a menu with a series of " +
                                "options - convert the text into Upper Case, Lower Case and Proper Case. The program " +
                                "should repeat until the user chooses option 4.\n" +
                                "   i.e Display may look like:\n" +
                                "   Enter some text:  Hello Everyone\n" +
                                "   \n" +
                                "   Select an option:\n" +
                                "       1)Convert to Upper Case\n" +
                                "       2)Convert to Lower Case\n" +
                                "       3)Convert to Proper Case\n" +
                                "       4)End\n" +
                                "   Choose:___\n" +
                                "Use an IF Statement or CASE to work on the menu\n"
            , "Task One") {}
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}