using Iteration.Papers.ProgramValidation.Tasks;
using Layout;

namespace Iteration.Papers.ProgramValidation
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{new TaskOne()}, "Validation & Selection") {}
    }
}