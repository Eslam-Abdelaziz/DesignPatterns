namespace Observer_Paern.Blog_subscription
{
    public interface ISubscriber
    {
        SubscriptionType Type { get; }
        void Notify(string message);
    }
}
