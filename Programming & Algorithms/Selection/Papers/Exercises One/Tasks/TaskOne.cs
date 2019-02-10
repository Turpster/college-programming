using System;
using Layout;

namespace Selection.Papers.Exercises_One.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that asks the user to enter a mark in the range 0 to 100 and " +
                                "outputs the corresponding exam grade, as in the following table:\n" +
                                "*------+-------+-------+-------+-------+--------+\n" +
                                "| < 40 | 40-49 | 50-59 | 60-69 | 70-79 | 80-100 |\n" +
                                "| U    | E     | D     | C     | B     | A      |\n" +
                                "*------+-------+-------+-------+-------+--------+\n",
            "Task One: Exam Grades") {}
        
        public override void Run()
        {
            int marks = Utils.AskUserInteger("Exam Mark");

            Grade.GradeType grade = Grade.ToGrade(marks);
            
            Console.WriteLine("Your grade was {0} since your scored {1}.", Grade.ToChar(grade), marks);
        }
    }
}