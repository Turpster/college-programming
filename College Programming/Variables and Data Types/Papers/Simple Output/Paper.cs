using Base;
using Variables_and_Data_Types.Papers.Simple_Output.Tasks;

namespace Variables_and_Data_Types.Papers.Simple_Output
{
    public class Paper : Base.Paper
    {
        public Paper() : base(new Task[] {new TaskOne(), new TaskTwo(), new TaskThree(), new TaskFour()}, "Simple Output Paper") {}
    }
}