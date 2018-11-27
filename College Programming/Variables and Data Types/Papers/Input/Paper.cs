using Executor;
using Variables_and_Data_Types.Papers.Random_Number.Tasks;

namespace Variables_and_Data_Types.Papers.Input
{
    public class Paper : Executor.Paper
    {
        public Paper() : base(new Task[] { new TaskOne(), new TaskTwo(), new TaskThree(), 
            new TaskFour(), new TaskFive(), }, "Simple Calculations Paper")
        {
            
        }
    }
}