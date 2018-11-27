using Layout;
using Procedures_and_Functions.Papers.ProcedureFunctionSheet.Tasks;

namespace Procedures_and_Functions.Papers.ProcedureFunctionSheet
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{ new TaskOne(), new TaskTwo() }, "Procedures and Function Sheet") {}
    }
}