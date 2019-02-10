using System;
using Layout;

namespace Selection.Papers.Selection_If_Else_Logic.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("Alter the program to take in two grades - a grade for Coursework and an Exam Grade. " +
                                "The program will work out an average of both and use this to evaluate the overall " +
                                "Grade given on the course.", 
            "Task Two") {}
        
        public override void Run()
        {
            string name = Utils.AskUserString("Name");
            
            Grade.GradeType examGrade = Grade.ToGrade(Utils.AskUserInteger("Exam Marks"));
            Grade.GradeType courseworkGrade = Grade.ToGrade(Utils.AskUserInteger("Exam Marks"));
            Grade.GradeType targetGrade = Grade.ToGrade(Utils.AskUserChar("Target Grade"));

            Console.WriteLine("{0}, you achieved a {1} for your Exam Grade in your recent test which is "
                              + (examGrade == targetGrade ? "equal" : (int) examGrade > (int) targetGrade ? "better" : "worse") + 
                              " than your TMG of a {2}. You also achieved a {3} in coursework", 
                name, Grade.ToChar(examGrade), Grade.ToChar(targetGrade), Grade.ToChar(courseworkGrade));
        }
    }
}