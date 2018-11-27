using Layout;

namespace Iteration.Papers.ForLoopBasics.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("Create the following program:\n" +
                                "static void Main(string[] args)\n" +
                                "{\n" +
                                "    Console.WriteLine(Convert.ToChar(65));\n" +
                                "    \n" +
                                "    Console.ReadLine();\n" +
                                "}\n" +
                                "a) What does it do?\n" +
                                "b) What does it do if you change the number to 66?\n" +
                                "c) What if you change the number to 80?\n" +
                                "d) Alter the program so that it allows the user to type in a number at the console " +
                                "and display the equivalent char(of that number).\n" +
                                "e) Produce a program that outputs the letters A to E using a For Loop\n" +
                                "f) Produce a program that outputs the letters G to N using a For Loop",
            "Task Two")
        {
        }

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}