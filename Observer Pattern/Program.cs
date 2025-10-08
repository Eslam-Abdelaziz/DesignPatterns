using DesignPatterns.Observer_Pattern.Amazon_product_subscription;
using Observer_Paern.Blog_subscription;

namespace Observer_Pattern;
public static class ObserverPattern
{
    public static void Run()
    {
        // Example 1: Amazon product subscription
        Console.WriteLine("\tExample1: Amazon product subscription. In this example, users subscribe to a product. When the product is back in stock, all subscribed users are notified.");
        var product = new Product("PlayStation 5", 1000, "Out Of Stock");
        var user1 = new User("Alice");
        var user2 = new User("Bob");
        product.RegisterObserver(user1);
        Console.WriteLine($"\t\t{user1.Name} registered to {product.Name}");
        product.RegisterObserver(user2);
        Console.WriteLine($"\t\t{user2.Name} registered to {product.Name}");
        product.SetAvailability("In Stock");

        // Example 2: Blog subscription
        Console.WriteLine("\tExample2: Blog and Newsletter subscription. In this example, users subscribe to either blogs or newsletters and are notified when new content is published.");
        var newsManager = new NewsManager();
        var blogSubscriber = new Subscriber("Charlie", SubscriptionType.NEWSBLOG);
        var newsletterSubscriber = new Subscriber("Diana", SubscriptionType.NEWSLETTER);
        newsManager.RegisterSubscriber(blogSubscriber, SubscriptionType.NEWSBLOG);
        Console.WriteLine($"\t\t{blogSubscriber.Name} subscribed to Blogs");
        newsManager.RegisterSubscriber(newsletterSubscriber, SubscriptionType.NEWSLETTER);
        Console.WriteLine($"\t\t{newsletterSubscriber.Name} subscribed to Newsletters");
        var blog = new Blog("Observer Pattern in C#", "A deep dive into the Observer Pattern.");
        var newsletter = new Newsletter("Design Patterns Weekly", "Latest updates on design patterns.");
        newsManager.writeNewBlog(blog);
        newsManager.writeNewsletter(newsletter);
        Console.WriteLine("     ----------------------------------------------------------------------------------------------------------------------------------");
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
    }
}