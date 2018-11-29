using Layout;
using Variables_and_Data_Types.Papers.Input.Tasks;

namespace Variables_and_Data_Types.Papers.Input
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[] { new TaskOne(), new TaskTwo(), new TaskThree(), 
            new TaskFour()}, "Input Paper")
        {
            
        }
    }
}