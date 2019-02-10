using Layout;

namespace Files.Papers.RecordStructuresExercise.Tasks
{
    public class TaskFive : Task
    {
        public TaskFive() : base("Alter the program to make use of a menu instead of just reading the file and outputting it:\n" +
                                 "  - The menu will contain the following options:\n" +
                                 "    - Sort books by title:\n" +
                                 "    - Search for a book based on title" +
                                 "    - Display all books\n" +
                                 "    - Quit\n" +
                                 "  - Use a Function (getMenuChoice) to allow the user to enter a valid menu option. " +
                                 "There must be suitable try/catch used within this.\n" +
                                 "  - For menu option 1, 2 and 3 there should be a separate routine to perform the " +
                                 "task.\n" +
                                 "    - will need to execute a bubble sort\n" +
                                 "    - will conduct a Binary Search\n" +
                                 "    - will make use of the procedure already coded."
            , "Task Five") {}

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}