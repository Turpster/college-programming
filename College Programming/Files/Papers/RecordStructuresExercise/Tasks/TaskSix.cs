using Layout;

namespace Files.Papers.RecordStructuresExercise.Tasks
{
    public class TaskSix : Task
    {
        public TaskSix() : base("Alter the program to allow another menu option that allows a book to be added to " +
                                "the end of the file.\n" +
                                "    - Alter the program to allow the array to be re-sized depending upon the number " +
                                "of books in the file.\n" +
                                "\n" +
                                "When adding a book – the user could add several books at once e.g:\n" +
                                "\n" +
                                "How many books do you wish to add? 3\n" +
                                "Please enter Book 1: (book details entered)\n" +
                                "Please enter Book 2: (book details entered)\n" +
                                "Please enter Book 3: (book details entered)\n" +
                                "Then if you selected again:\n" +
                                "How many books do you wish to add? 2\n" +
                                "Please enter Book 4: (book details entered)\n" +
                                "Please enter Book 5: (book details entered)\n" +
                                "\n" +
                                "Think carefully – you will have to use a different style of loop (thinking about loop until a value = null) "
            , "Task Three") {}

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}