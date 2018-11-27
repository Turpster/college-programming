using Layout;

namespace Selection.Papers
{
    public class Selection : Project
    {
        public Selection() : base(
            new Paper[]
            {
                new SelectionPaper.Paper(), 
                new Selection_If_Basics.Paper(),
                new Selection_If_Else.Paper(),
                new Selection_If_Else_Logic.Paper(),
                new Case_Statements.Paper(), 
                new Exercises_One.Paper(), 
                new Exercises_Two.Paper(), 
            }, "Selection") 
        {}

        public static void Main(string[] args)
        {
            Layout.Executor.AddProject(new Selection());
        }
    }
}