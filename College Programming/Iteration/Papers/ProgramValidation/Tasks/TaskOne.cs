using System;
using Layout;
using Selection.Papers;

namespace Iteration.Papers.ProgramValidation.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Specification:\n" +
                                
                                "Write a program that takes in a course work mark and an exam mark - both must be " +
                                "validated to be out of 75. \n" +
                                
                                "A student name (including first name and surname is entered at once separated by a " +
                                "comma e.g. Smith, Darren). This must be at least 5 characters long. The program " +
                                "will split this into two variables firstname and surname.\n" +
                                
                                "The course name is also entered – this must be at least two characters long.\n" +
                                
                                "Once both marks have been entered correctly between 0 and 75 – an average of the " +
                                "marks is taken. A percentage of the mark is then taken and stored.\n" +
                                
                                "If the student gained 40% they get an E, 50% = D, 60% = C, 70% = B, 85% = A\n" +
                                
                                "After the calculation the program will print out the students name, course and " +
                                "grade that they achieved."
            , "Paper Task") {}

        public override void Run()
        {
            string[] fullname = new string[2];

            bool nameCheck = true;
            while (nameCheck)
            {
                fullname = Utils.AskUserNameAndSurname();
                foreach (string name in fullname)
                {
                    if (name.Length < 5)
                    {
                        Console.WriteLine("Invalid name, needs to be at least 5 characters long.");
                    }
                    else nameCheck = false;
                }
            }

            string course = "";
            
            bool courseCheck = true;
            while (courseCheck)
            {
                course = Utils.AskUserString("Enter the course name");
                if (course.Length < 2)
                {
                    Console.WriteLine("Invalid Course Name");
                }
                else courseCheck = false;
            }

            int courseWorkMark = Utils.AskUserInteger("What mark did you get in your course work");
            int examMark = Utils.AskUserInteger("What mark did you get in your exam");

            int courseWorkMarkPercentage = courseWorkMark / 75;
            int examMarkPercentage = examMark / 75;

            int average = (courseWorkMarkPercentage * examMarkPercentage) / 2;
            
            Grade.GradeType grade;

            if (average < 40)
            {
                grade = Grade.GradeType.U;
            }
            else if (average < 50)
            {
                grade = Grade.GradeType.E;
            }
            else if (average < 60)
            {
                grade = Grade.GradeType.D;
            }
            else if (average < 70)
            {
                grade = Grade.GradeType.C;
            }
            else if (average < 85)
            {
                grade = Grade.GradeType.B;
            }
            else
            {
                grade = Grade.GradeType.A;
            }
                
            Console.WriteLine("{0},{1} you scored {2} in the {3} course.", fullname[0], fullname[1], Grade.ToChar(grade), course);
        }
    }
}