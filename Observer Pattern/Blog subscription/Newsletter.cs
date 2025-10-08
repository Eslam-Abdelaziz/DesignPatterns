namespace Observer_Paern.Blog_subscription
{
    public class Newsletter
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Newsletter(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
}