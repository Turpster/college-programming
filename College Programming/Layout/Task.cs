namespace Layout
{
    public abstract class Task
    {
        public string Question { get; }

        public string Title { get; }
        
        protected Task(string question, string title)
        {
            this.Question = question;
            this.Title = title;
        }
        
        public abstract void Run();
    }
}