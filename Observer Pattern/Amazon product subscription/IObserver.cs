namespace DesignPatterns.Observer_Pattern.Amazon_product_subscription
{
    public interface IObserver
    {
        // Receive Notification from Subject
        void Update(string name, string availability);
    }
}