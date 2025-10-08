namespace Observer_Paern.Blog_subscription
{
    public class Blog
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Blog(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}