namespace Layout
{
    public abstract class Paper
    {
        public Task[] Tasks { get; }

        public string Title { get; }
        public string Comments { get; }
    
        protected Paper(Task[] tasks, string title, string comments)
        {
            this.Tasks = tasks;
            this.Title = title;
            this.Comments = comments;
        }

        
        protected Paper(Task[] tasks, string title)
        {
            this.Tasks = tasks;
            this.Title = title;
            this.Comments = null;
        }
    }
}