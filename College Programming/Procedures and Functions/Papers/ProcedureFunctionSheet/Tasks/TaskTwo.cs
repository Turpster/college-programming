using Layout;

namespace Procedures_and_Functions.Papers.ProcedureFunctionSheet.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("The following program is to model a basic calculator.\n" +
                                "  a. Declare four local variables within the Main routine (num1, num2, total, operator)\n" +
                                "  b. Write a Function called getValidNumber() – this will contain no parameters, but " +
                                "the purpose is to return a valid number that is an interget within the range of 0 " +
                                "to 100 inclusively.\n" +
                                "  c. From the Main routine – use the getValidNumber twice. Once for num1 and once for " +
                                "num2. Output these numbers to the Console to show that this works.\n" +
                                "  d. Produce four routines – one for each of addition, subtraction, multiplication " +
                                "and division. The routines will receive two parameters – num1 and num2.\n" +
                                "    i.Within the routines calculate the total and return this to the calling routine.\n" +
                                "  e. Code the Main Routine so that depending upon what operator the user chooses it " +
                                "will use the specific routine. E.g. if they enter “+” then it will call the " +
                                "Addition Routine.\n" +
                                "  f. Ensure the program continually loops allowing the user to perform many " +
                                "calculations.\n"
            , "Task Two"){}
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}