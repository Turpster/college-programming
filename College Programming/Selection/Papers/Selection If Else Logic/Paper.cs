using Layout;
using Selection.Papers.Selection_If_Else_Logic.Tasks;

namespace Selection.Papers.Selection_If_Else_Logic
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[] {new TaskOne(), new TaskTwo(), new TaskThree(), new TaskFour()}, "Selection If Else Logic", 
            "For each of these programming tasks, create and test a program. For each:\n" +
            "- Add comments with a description of the task, your name and the date" +
            "- Copy the program to a Word document\n" +
            "- Paste a screen shot of the console as evidence that the program worked\n" +
            "- Check that you have your name, set and date in a header") {}
        
        /*
           TODO
           Do the above
         */
   }
}