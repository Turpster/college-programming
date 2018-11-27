using Executor;
using Variables_and_Data_Types.Papers.Input.Tasks;
using TaskOne = Variables_and_Data_Types.Papers.Variable_Exercises_2.Tasks.TaskOne;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_2
{
    public class Paper : Executor.Paper
    {
        public Paper() : base( new Task[] {new TaskOne(), new TaskTwo(), new TaskThree()}, "Variable Exercises 2", 
            "For each of these programming tasks, create and test a program. For each:\n" +
            "- Produce Pseudocode to plan the program in advance\n" +
            "- Add comments with a description of the task, your name and the date\n" +
            "- Copy the program to a Word document\n" +
            "- Paste a screen shot of the console as evidence that the program worked\n" +
            "- Check that you have your name and date in a header\n"
            ){}
    }
}