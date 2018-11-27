using Arrays.Papers.ArraysWorksheetThree.Tasks;
using Layout;

namespace Arrays.Papers.ArraysWorksheetThree
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{ new TaskOne(), new TaskTwo(), new TaskThree(), new TaskFour() }, "Arrays Worksheet Three") {}
    }
}