using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Simple_Output.Tasks
{
    public class TaskThree : Task
    {
        public TaskThree() : base("Display the name of your village or town four times. Put it on a different line " +
                                  "each time, using four different foreground colours and four different background " +
                                  "colours",
            "Task Three")
        {}

        public override void Run()
        {
            var oldColor = new ConsoleColor[] {Console.ForegroundColor, Console.BackgroundColor};
            
            string town = "Cleethorpes";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(town);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(town);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(town);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(town);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(town);

            Console.ForegroundColor = oldColor[0];
            Console.BackgroundColor = oldColor[1];
        }
        
    }
}