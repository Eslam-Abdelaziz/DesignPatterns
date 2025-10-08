namespace Observer_Paern.Blog_subscription
{
    public class Subscriber : ISubscriber
    {
        public SubscriptionType Type { get; private set; }
        public string Name { get; set; }

        public Subscriber(string name, SubscriptionType type)
        {
            Name = name;
            Type = type;
        }

        public void Notify(string message)
        {
            Console.WriteLine($"\t\t{Name} received: {message}");
        }
    }
}
