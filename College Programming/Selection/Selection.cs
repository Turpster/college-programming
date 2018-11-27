using Layout;

namespace Selection
{
    public class Selection : Project
    {
        public Selection() : base(
            new Paper[]
            {
                new Papers.SelectionPaper.Paper(), 
                new Papers.Selection_If_Basics.Paper(),
                new Papers.Selection_If_Else.Paper(),
                new Papers.Selection_If_Else_Logic.Paper(),
                new Papers.Case_Statements.Paper(), 
                new Papers.Exercises_One.Paper(), 
                new Papers.Exercises_Two.Paper()
            }, "Selection") 
        {}

        public static void Main(string[] args)
        {
            Layout.Executor.AddProject(new Selection());
        }
    }
}