using Layout;

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
                                
                                "If the student gained 40 % they get an E, 50% = D, 60% = C, 70% = B, 85% = A\n" +
                                
                                "After the calculation the program will print out the students name, course and " +
                                "grade that they achieved."
            , "Paper Task")
        {
        }

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}