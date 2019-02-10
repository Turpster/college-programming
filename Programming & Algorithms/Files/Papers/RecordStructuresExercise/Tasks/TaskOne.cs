using Layout;

namespace Files.Papers.RecordStructuresExercise.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("A book consists of an ISBN number, a title, an author, year of publish and a publisher.\n" +
                                "Create a record structure to hold this data."
            , "Task One") {}

        public struct Book
        {
            public int ISBNNumber;
            public string Title;
            public string Author;
            public int YearOfPublic;

            public Book(int isbnNumber, string title, string author, int yearOfPublic)
            {
                ISBNNumber = isbnNumber;
                Title = title;
                Author = author;
                YearOfPublic = yearOfPublic;
            }
        }

        public override void Run()
        {
            Book book;
            int num = Utils.AskUserInteger("ISBNNumber");
            book = new Book();
        }
    }
}