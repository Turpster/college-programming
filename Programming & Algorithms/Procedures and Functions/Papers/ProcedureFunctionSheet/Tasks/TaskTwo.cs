using System;
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

        private double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        private double Sub(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        private double Mul(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }
        private double Div(double numOne, double numTwo)
        {
            return numOne / numTwo;
        }
        
        private double GetValidNumber(string request)
        {
            return Utils.AskUserDouble(request);
        }
        
        public override void Run()
        {
            double num1 = GetValidNumber("Number One");
            double num2 = GetValidNumber("Number Two");
            
            char opp = Utils.AskUserChar("Please input your operator (+|-|*|/)");

            double total;
            
            if (opp == '+')
            {
                total = Add(num1, num2);
                Console.WriteLine("{0} {1} {2} = {3}", num1, opp, num2, total);
            }
            else if (opp == '-')
            {
                total = Sub(num1, num2);
                Console.WriteLine("{0} {1} {2} = {3}", num1, opp, num2, total);
            }
            else if (opp == '*')
            {
                total = Mul(num1, num2);
                Console.WriteLine("{0} {1} {2} = {3}", num1, opp, num2, total);
            }
            else if (opp == '/')
            {
                total = Div(num1, num2);
                Console.WriteLine("{0} {1} {2} = {3}", num1, opp, num2, total);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
                Run();
            }
        }
    }
}