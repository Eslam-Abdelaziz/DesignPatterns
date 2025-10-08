using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer_Pattern.Amazon_product_subscription
{
    public class User: IObserver
    {
        private string name;
        public string Name { get { return name; } }
        public User(string name)
        {
            this.name = name;
        }
        public void Update(string name, string availability)
        {
            Console.WriteLine($"\t\tHello {this.name}, the product {name} is now {availability}.");
        }
    }
}
