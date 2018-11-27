using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Input.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("Write a program that asks the user for their name and birthday. Then display an output similar to:\n" +
                                "Hello Fred, your birthday is 12/3/1998", 
            "Task Two")
        {}

        public override void Run()
        {
            Console.Write("Name");
            string name = Console.ReadLine();
            Console.Write("Birthday");
            string birthday = Console.ReadLine();

            Console.WriteLine("Hello {0}, your birthday is {1}.", name, birthday);
        }
    }
}