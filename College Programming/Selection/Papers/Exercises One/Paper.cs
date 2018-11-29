using Layout;
using Selection.Papers.Exercises_One.Tasks;

namespace Selection.Papers.Exercises_One
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[] { new TaskOne(), new TaskTwo() }, "Exercises One") {}
    }
}