using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Output.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("Write a program that displays your name in blue letters and white background",
            "Task Two")
        {}

        public override void Run()
        {
            var oldColor = new ConsoleColor[] {Console.ForegroundColor, Console.BackgroundColor};
            
            string name = Utils.AskUserString("Name");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(name);

            Console.ForegroundColor = oldColor[0];
            Console.BackgroundColor = oldColor[1];
        }
        
    }
}