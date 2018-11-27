using Base;
using Variables_and_Data_Types.Papers.Input.Tasks;
using TaskOne = Variables_and_Data_Types.Papers.Variable_Exercises_2.Tasks.TaskOne;

namespace Variables_and_Data_Types.Papers.Variable_Exercises_2
{
    public class Paper : Base.Paper
    {
        public Paper() : base( new Task[] {new TaskOne(), new TaskTwo(), new TaskThree()}, "Variable Exercises 2", 
            "For each of these programming tasks, create and test a program. For each:" +
            "- Produce Pseudocode to plan the program in advance" +
            "- Add comments with a description of the task, your name and the date" +
            "- Copy the program to a Word document" +
            "- Paste a screen shot of the console as evidence that the program worked" +
            "- Check that you have your name and date in a header"
            ){}
    }
}