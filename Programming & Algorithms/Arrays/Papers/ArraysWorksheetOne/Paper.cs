using Arrays.Papers.ArraysWorksheetOne.Tasks;
using Layout;

namespace Arrays.Papers.ArraysWorksheetOne
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{new TaskOne()}, "Arrays Worksheet One") {}
    }
}