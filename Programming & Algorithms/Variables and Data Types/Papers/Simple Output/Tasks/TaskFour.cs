using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Output.Tasks
{
    public class TaskFour : Task
    {
        public TaskFour() : base("Investigate this new VB statement\n" +
                                 "Console.Clear()\n" +
                                 "What does it do?\n" +
                                 "Write a program that used this statement.",
            "Task Four")
        {}

        public override void Run()
        {
            Console.Write("Do you want to clear the window? (Y/n): ");
            char selection = Console.ReadKey().KeyChar;
            Console.Write(".\n");
            if (selection == 'Y' || selection == 'y')
            {
                Console.Clear();
                Console.WriteLine("Console.Clear(); will clear the console buffer and corresponding console window " +
                                  "of display information");
            }
            else
            {
                Console.Write("Operation Cancelled.");
            }
        }
        
    }
}