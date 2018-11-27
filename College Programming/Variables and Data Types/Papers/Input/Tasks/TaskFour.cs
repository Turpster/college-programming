using System;
using Layout;

namespace Variables_and_Data_Types.Papers.Input.Tasks
{
    public class TaskFour : Task
    {
        public TaskFour() : base("Amend the program you created for task 4, where the computer asks for the platform " +
                                 "number and time. The program displays a similar message to that in task 4, but " +
                                 "with your entered platform and time.",
            "Task Four")
        {}

        public override void Run()
        {
            Console.Write("Platform: ");
            string platform = Console.ReadLine();
            
            Console.Write("Time: ");
            string time = Console.ReadLine();
            Console.Write("{0} wish to announce that\n" +
                          "the coastal express will depart from platform\n" +
                          "2 at {1}", platform, time);
        }
    }
}