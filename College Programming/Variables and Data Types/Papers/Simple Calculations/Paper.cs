using Layout;
using Variables_and_Data_Types.Papers.Simple_Calculations.Tasks;

namespace Variables_and_Data_Types.Papers.Simple_Calculations
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[] { new TaskOne(), new TaskTwo(), new TaskThree(), 
            new TaskFour(), new TaskFive(), new TaskSix(), new TaskSeven(), }, "Simple Calculations Paper")
        {
            
        }
    }
}