using Layout;

namespace Pre_Release.Onedrive_Data.NoughtsAndCrosses
{
    public class Paper : Layout.Paper
    {
        public Paper(Task[] tasks, string title, string comments) : base(tasks, title, comments)
        {
        }

        public Paper(Task[] tasks, string title) : base(tasks, title)
        {
        }
    }
}