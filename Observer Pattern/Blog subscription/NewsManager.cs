namespace Observer_Paern.Blog_subscription
{
    public class NewsManager
    {
        private Dictionary<SubscriptionType, List<ISubscriber>> subscribers;
        private List<Blog> blogs;
        private List<Newsletter> newsletters;
        public NewsManager() 
        {
            subscribers = new Dictionary<SubscriptionType, List<ISubscriber>>();
            blogs = new List<Blog>();
            newsletters = new List<Newsletter>();
        }
        public void writeNewBlog(Blog blog)
        {
            blogs.Add(blog);
            Console.WriteLine($"\t\tNew blog with title '{blog.Title}' is added");
            notifySubscribers(SubscriptionType.NEWSBLOG, "New blog is published...");
        }
        public void writeNewsletter(Newsletter newsletter)
        {
            newsletters.Add(newsletter);
            Console.WriteLine($"\t\tNew news letter with title '{newsletter.Title}' is added");
            notifySubscribers(SubscriptionType.NEWSLETTER, "New newsletter is published...");
        }
        public void notifySubscribers(SubscriptionType type, string message)
        {
            if (subscribers.TryGetValue(type, out var Subscribers))
            {
                foreach (var Subscriber in Subscribers)
                {
                    Subscriber.Notify(message);
                }
            }
        }
        public void RegisterSubscriber(ISubscriber subscriber, SubscriptionType type)
        {
            if (!subscribers.ContainsKey(type))
            {
                subscribers[type] = new List<ISubscriber>();
            }
            subscribers[type].Add(subscriber);
        }
        public void RemoveSubscriber(ISubscriber subscriber, SubscriptionType type)
        {
            if (subscribers.TryGetValue(type, out var Subscribers))
            {
                Subscribers.Remove(subscriber);
            }
        }
    }
}
