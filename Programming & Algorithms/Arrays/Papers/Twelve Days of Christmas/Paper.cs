using Arrays.Papers.Twelve_Days_of_Christmas.Tasks;
using Layout;

namespace Arrays.Papers.Twelve_Days_of_Christmas
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[]{new TaskOne()}, "Twelve Days of Christmas") {}
    }
}