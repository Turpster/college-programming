using Layout;

namespace Selection.Papers.SelectionPaper.Tasks
{
    public class TaskTwo : Task
    {
        public TaskTwo() : base("- Modify your solution to Assessment 1 (double glazing calculator) so that the " +
                                      "width and height are validated as follows:\n" +
                                      "  - Width must be between 0.5 and 5.0\n" +
                                      "  - Height must be between 0.75 and 3.0\n" +
                                      "- If a value is entered which is smaller than the minimum then the minimum " +
                                      "should be used instead. Likewise for the maximum.\n" +
                                      "- Some indication should be given to the user that minimum or maximum values " +
                                      "have been used.",
            "Assessment 1 - Simple Validation")
        {
        }

        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}