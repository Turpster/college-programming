using System;
using Layout;

namespace Selection.Papers.SelectionPaper.Tasks
{
    public class TaskFour : Task
    {
        public TaskFour() : base("- Write a program to request an input number (less than 20) and inform the user if " +
                                 "it is a prime number or not.",
            "Program 2B - Prime Number Checker")
        {
        }

        public override void Run()
        {
            Console.WriteLine(IsPrime(Utils.AskUserInteger("Number")) ? "Number is Prime" : "Number is not prime");
        }
        
        // Soner's Routine
        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number)); //hoisting the loop limit

            for (int i = 2; i <= limit; ++i)  {
                if (number % i == 0)  return false;
            }

            return true;
        }
    }
}