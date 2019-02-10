using System;
using System.Threading;
using Layout;

namespace Selection.Papers.Selection_If_Else_Logic.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that allows a student’s name & a mark to be entered for a Student -" +
                                " along with their Target Minimum Grade (as a single grade). The Program will work " +
                                "out their Grade and output a message for them as follows:\n" +
                                
                                "\"Mary, you achieved a C in your recent test which is better than your TMG of a D\"\n" +
                                
                                "  If the student scored less than 40 then they scored a U\n" +
                                "  If the student scored between 40 and 49 then they scored a D\n" +
                                "  If the student scored between 50 and 59 then they scored a C\n" +
                                "  60 - 69 is a B\n" +
                                "  Above 70 is an A\n" +
                                
                                "TMG can be entered as a single grade D – A", 
            "Task One") {} 
        public override void Run()
        {
            string name = Utils.AskUserString("Name");
            Grade.GradeType grade;
            Grade.GradeType targetGrade;
            grade = Grade.ToGrade(Utils.AskUserInteger("Exam Marks"));
            try
            {
                targetGrade = Grade.ToGrade(Utils.AskUserChar("Target Grade"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Grade (U|D|C|B|A)");
                Run(); return;
            }

            if (targetGrade == Grade.GradeType.E)
            {
                Console.WriteLine("You cannot enter an E grade");
                Run(); return;
            }

            Console.WriteLine("{0}, you achieved a {1} in your recent test which is "
                              + (grade == targetGrade ? "equal" : (int) grade > (int) targetGrade ? "better" : "worse") + 
                              " than your TMG of a {2}.", name, Grade.ToChar(grade), Grade.ToChar(targetGrade));
            
        }
    }
}