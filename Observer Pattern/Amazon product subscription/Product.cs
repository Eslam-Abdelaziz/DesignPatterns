namespace DesignPatterns.Observer_Pattern.Amazon_product_subscription
{
    public class Product : ISubject
    {
        private List<IObserver> observers;
        private string name;
        private long price;
        private string availability;
        public string Name { get { return name; } }
        public Product(string name, long price, string availability)
        {
            this.name = name;
            this.price = price;
            this.availability = availability;
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(name, availability);
            }
        }
        public void SetAvailability(string availability)
        {
            this.availability = availability;
            Console.WriteLine($"\t\t{name} is now {availability}");
            this.NotifyObservers();
        }
    }
}
