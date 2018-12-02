using System;
using Layout;

namespace Procedures_and_Functions.Papers.ProcedureFunctionSheet.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Define and code a procedure called “OutputMessage” that takes no parameters and " +
                                "performs one task - outputting the text: “This is a procedure call”. Call this from " +
                                "the Main Routine."
            , "Task One"){}

        private void OutputMessage()
        {
//            Console.WriteLine("Everything is technically called from the Main 𝙛𝙪𝙣𝙘𝙩𝙞𝙤𝙣");
            Console.WriteLine("This is a procedure call");
        }
        
        public override void Run()
        {
            OutputMessage();
        }
    }
}