namespace Layout
{
    public abstract class Project
    {
        public Paper[] Papers { get; }

        public string Title { get; }
        
        protected Project(Paper[] papers, string title)
        {
            this.Papers = papers;
            this.Title = title;
        }
    }
}