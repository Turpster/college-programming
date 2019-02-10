using System;
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
            Console.WriteLine("{\n" +
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
                              "f) Produce a program that outputs the letters G to N using a For Loop");
            string selection = Utils.AskUserChar("Selection").ToString();

            if (selection.Equals("a", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine(
                    "1. Will convert the integer specified to a character\n" +
                    "  - The same result will be made when casting to a char (char) <num>\n" +
                    "2. Console will output the value of the converted integer \"65\" which is equal to the character 'A'.\n" +
                    "3. Console.ReadLine() will wait for the enter key to be pressed in order to continue with the code (a make-do code-break)");
            }
            else if (selection.Equals("b", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine(
                    "1. The value of Convert.ToChar(<int>) will be 'B' since that corresponds to the characters decimal value.\n" +
                    "2. The letter 'B' will be outputted.");

            }
            else if (selection.Equals("c", StringComparison.InvariantCultureIgnoreCase))
            {                
                Console.WriteLine(
                    "1. The value of Convert.ToChar(<int>) will be 'P' since that corresponds to the characters decimal value.\n" +
                    "2. The letter 'P' will be outputted.");
            }
            else if (selection.Equals("d", StringComparison.InvariantCultureIgnoreCase))
            {                
                int charint = Utils.AskUserInteger("Selection");
                Console.WriteLine("Value: {0}.", Convert.ToChar(charint));
            }
            else if (selection.Equals("e", StringComparison.InvariantCultureIgnoreCase))
            {
                for (char i = 'A'; i <= 'E'; i++)
                {
                    Console.WriteLine(i);
                }
                
            }
            else if (selection.Equals("f", StringComparison.InvariantCultureIgnoreCase))
            {                
                for (char i = 'G'; i <= 'N'; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid selection.");
                Run();
            }
        }

        private void RunSnippet()
        {
            Console.WriteLine(Convert.ToChar(65));

            Console.ReadLine();
        }
    }
}