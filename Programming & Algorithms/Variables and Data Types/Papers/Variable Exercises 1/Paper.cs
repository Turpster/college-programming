using Layout;
using Variables_and_Data_Types.Papers.Variable_Exercises_1.Tasks;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_1
{
    public class Paper : Layout.Paper
    {
        public Paper() : base( new Task[] {new TaskOne(), new TaskTwo(), new TaskThree()}, "Variable Exercises 1") {}
    }
}