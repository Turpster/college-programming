namespace Layout
{
    public abstract class Project
    {
        public Paper[] Papers { get; }

        public string Title { get; }
        
        protected Project(Paper[] papers, string title)
        {
            Papers = papers;
            Title = title;
        }
    }
}