using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Calculations.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that asks for 2 numbers and then display the result of the " +
                                "following calculations: \n" +
                                "- The two numbers added together\n" +
                                "- Number 1 subtracted from number 2\n" +
                                "- Number 1 divided by number 2\n" +
                                "- Number 1 raised to the power of number 2 (Keep numb 2 less than 5)\n",
            "Task One")
        {}

        public override void Run()
        {
            double num1 = Utils.AskUserDouble("Please enter your first number");
            double num2 = Utils.AskUserDouble("Please enter your second number");
            
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0}^{1} = {2}", num1, num2, Math.Pow(num1, num2));
        }
        
    }
}