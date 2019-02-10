using Iteration.Papers.ForLoopsAdvanced.Tasks;
using Layout;

namespace Iteration.Papers.ForLoopsAdvanced
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[] {new TaskOne()}, "For Loops Advanced") {}
    }
}