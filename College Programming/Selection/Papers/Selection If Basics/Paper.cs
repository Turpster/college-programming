using System.Net.Http.Headers;
using Layout;
using Selection.Papers.Selection_If_Basics.Tasks;

namespace Selection.Papers.Selection_If_Basics
{
    public class Paper : Layout.Paper
    {
        public Paper() : base(new Task[] { new TaskOne(), new TaskTwo(), new TaskThree() } , "Selection If Basics") {}
   }
}