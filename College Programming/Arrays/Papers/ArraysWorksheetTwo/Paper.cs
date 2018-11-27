using Arrays.Papers.ArraysWorksheetTwo.Tasks;
using Layout;

namespace Arrays.Papers.ArraysWorksheetTwo
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{new TaskOne()}, "Arrays Worksheet Two") {}
    }
}