using Iteration.Papers.StringFunctionsOne.Tasks;
using Layout;

namespace Iteration.Papers.StringFunctionsOne
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{ new TaskOne(), new TaskTwo() }, "String Functions One") {}
    }
}