namespace Layout
{
    public abstract class Paper
    {
        public Task[] Tasks { get; }

        public string Title { get; }
        public string Comments { get; }
    
        protected Paper(Task[] tasks, string title, string comments)
        {
            Tasks = tasks;
            Title = title;
            Comments = comments;
        }

        
        protected Paper(Task[] tasks, string title)
        {
            Tasks = tasks;
            Title = title;
            Comments = null;
        }
    }
}