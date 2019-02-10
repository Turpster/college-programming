using System;
using Layout;

namespace Iteration.Papers.ForLoopBasics.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Produce a program that has a menu (see sample starter task used in lesson). The " +
                                "menu will have the following options:\n" +
                                "   1. Display the numbers 1 to 100\n" +
                                "   2. Display the numbers 3 to 11\n" +
                                "   3. Display the numbers -10 to 10\n" +
                                "   4. Display the numbers between two values specified by the user\n" +
                                "To complete each of the tasks make use of a For Loop", 
            "Task One") {}
        
        public override void Run()
        {
            int selection = Utils.AskUserInteger("1. Display the numbers 1 to 100\n" +
                                                 "2. Display the numbers 3 to 11\n" +
                                                 "3. Display the numbers -10 to 10\n" +
                                                 "4. Display the numbers between two values specified by the user\n" +
                                                 "Selection");

            if (selection == 1)
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (selection == 2)
            {
                for (int i = 3; i <= 11; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (selection == 3)
            {
                for (int i = -10; i <= 10; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else if (selection == 4)
            {
                int lowerBound = Utils.AskUserInteger("Lower Bound");
                int upperBound = Utils.AskUserInteger("Upper Bound");
                
                for (int i = lowerBound; i <= upperBound; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid Selection");
                Run();
            }
        }
    }
}