using Layout;
using Selection.Papers.Exercises_Two.Tasks;

namespace Selection.Papers.Exercises_Two
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[] { new TaskOne() }, "Exercises Two") {}
    }
}