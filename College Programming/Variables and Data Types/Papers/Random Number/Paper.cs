using Base;
using Variables_and_Data_Types.Papers.Random_Number.Tasks;

namespace Variables_and_Data_Types.Papers.Random_Number
{
    public class Paper : Base.Paper
    {
        public Paper() : base(new Task[] { new TaskOne(), new TaskTwo(), new TaskThree(), 
            new TaskFour(), new TaskFive(), }, "Simple Calculations Paper")
        {
            
        }
    }
}