using Layout;

namespace Selection.Papers.Exercises_One.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that asks the user to enter a mark in the range 0 to 100 and " +
                                "outputs the corresponding exam grade, as in the following table:" +
                                "*------+-------+-------+-------+-------+--------+\n" +
                                "| < 40 | 40-49 | 50-59 | 60-69 | 70-79 | 80-100 |" +
                                "| U    | E     | D     | C     | B     | A      |" +
                                "*------+-------+-------+-------+-------+--------+\n",
            "Task 1: Exam Grades") {}

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}