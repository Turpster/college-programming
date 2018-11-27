using Layout;
using Selection.Papers.SelectionPaper.Tasks;

namespace Selection.Papers.SelectionPaper
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[] {new TaskOne(), new TaskTwo(), new TaskThree(), new TaskFour(), new TaskFive(), new TaskSix(), new TaskSeven()}, "Selection") {}
    }
}