using Layout;

namespace Selection.Papers.Selection_If_Else_Logic.Tasks
{
    public class TaskOne : Task
    {
        public TaskOne() : base("Write a program that allows a student’s name & a mark to be entered for a Student -" +
                                " along with their Target Minimum Grade (as a single grade). The Program will work " +
                                "out their Grade and output a message for them as follows:\n" +
                                
                                "\"Mary, you achieved a C in your recent test which is better than your TMG of a D\"\n" +
                                
                                "  If the student scored less than 40 then they scored a U\n" +
                                "  If the student scored between 40 and 49 then they scored a D\n" +
                                "  If the student scored between 50 and 59 then they scored a C\n" +
                                "  60 - 69 is a B\n" +
                                "  Above 70 is an A\n" +
                                
                                "TMG can be entered as a single grade D – A", 
            "Task One") {}
        
        public override void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}