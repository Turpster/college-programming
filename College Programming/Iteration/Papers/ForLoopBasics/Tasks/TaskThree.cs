using System;
using Layout;

namespace Iteration.Papers.ForLoopBasics.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Produce a program that has a menu with the following options all completed using " +
                                  "a For Loop (You will need to use the ‘modification to value’ part of the for loop " +
                                  "differently than you have up to now.\n" +
                                  "Remember:\n" +
                                  "for (initial value; test condition; modification to value)\n" +
                                  "{\n" +
                                  "// do some task\n" +
                                  "}\n" + 
                                  "Eg: \n" + 
                                  "for (int i = 0; i <= 100; i = i + 10\n" + 
                                  "{\n" + 
                                  "    Console.WriteLine(i);\n" + 
                                  "}\n" + 
                                  "\n" +
                                  "1) Output odd numbers between 1 and a number specified by the user\n" +
                                  "2) Output every other letter of the alphabet\n" +
                                  "3) Ask the user to enter a start number, end number and also an interval – display each number e.g.\n" +
                                  "    a. Start number is -5 and interval is 5 so it would display -5, 0, 5, 10, 15 \n" +
                                  "4) As of 3 but counting down a series of numbers",
            "Task Three") {}

        public override void Run()
        {
            
            Console.WriteLine("1) Output odd numbers between 1 and a number specified by the user\n" +
                              "2) Output every other letter of the alphabet\n" +
                              "3) Ask the user to enter a start number, end number and also an interval – display each number e.g.\n" +
                              "    a. Start number is -5 and interval is 5 so it would display -5, 0, 5, 10, 15 \n" +
                              "4) As of 3 but counting down a series of numbers");
            
            int selection = Utils.AskUserInteger("Selection");

            if (selection == 1)
            {
                int endnum = Utils.AskUserInteger("End Number");
                for (int i = 1; i <= endnum; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else if (selection == 2)
            {
                char excludedChar = Utils.AskUserChar("Character you want to exclude");
                
                for (char i = 'A'; i <= 'Z'; i++)
                {
                    if (excludedChar != i)
                        Console.WriteLine(i);
                }
            }
            else if (selection == 3)
            {
                int start = Utils.AskUserInteger("Start");
                int end = Utils.AskUserInteger("End");
                int interval = Utils.AskUserInteger("interval");

                for (; start < end - interval; start += interval)
                {
                    Console.WriteLine(start);
                }
            }
            else if (selection == 4)
            {
                // Hmm, As of 3 but counting down a series of numbers?
                // I'll take that as start from 3 and count down a series of numbers.
                
                for (int i = 3; i >= -27; i--)
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