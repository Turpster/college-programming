using Layout;
using Procedures_and_Functions.Papers.MiniProjectProceduresFunctions.Tasks;

namespace Procedures_and_Functions.Papers.MiniProjectProceduresFunctions
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{new TaskOne()}, "Mini Project Procedures Functions") {}
    }
}