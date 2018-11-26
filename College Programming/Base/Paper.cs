namespace Base
{
    public abstract class Paper
    {
        public Task[] Tasks { get; }

        public string Title { get; }
        
        protected Paper(Task[] tasks, string title)
        {
            this.Tasks = tasks;
            this.Title = title;
        }
    }
}