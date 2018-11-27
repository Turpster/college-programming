namespace Executor
{
    public abstract class Task
    {
        public string Question { get; }

        public string Title { get; }
        
        protected Task(string question, string title)
        {
            Question = question;
            Title = title;
        }
        
        public abstract void Run();
    }
}