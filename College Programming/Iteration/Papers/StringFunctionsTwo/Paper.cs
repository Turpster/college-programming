using Iteration.Papers.StringFunctionsTwo.Tasks;
using Layout;

namespace Iteration.Papers.StringFunctionsTwo
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{ new TaskOne() }, "String Functions Two") {}
    }
}