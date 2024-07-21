using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Order> orders = new List<Order>();
        for (int j = 0; j<2; j++)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your address?");
            Console.Write("Street?");
            string street = Console.ReadLine();
            Console.Write("City?");
            string city = Console.ReadLine();
            Console.Write("State?");
            string state = Console.ReadLine();
            Console.Write("Country?");
            string country = Console.ReadLine();

            Address address = new Address(street,city,state,country);
            Customer customer = new Customer(name,address);
            Order newOrder = new Order(customer);
            for (int i = 0; i<3;i++)
            {
                Console.WriteLine("What is the name of the product?");
                string productName = Console.ReadLine();
                Console.WriteLine("What is the Product ID");
                string id = Console.ReadLine();
                Console.WriteLine("What is the price");
                double price = double.Parse(Console.ReadLine());
                Console.WriteLine($"How many {productName} are you getting?");
                int quantity = int.Parse(Console.ReadLine());
                Product newProduct = new Product(productName,id,price,quantity);
                newOrder.AddItem(newProduct);
            }
            orders.Add(newOrder);
        }

        foreach(Order item in orders)
        {
            Console.WriteLine(item.PackingLabel());
            Console.WriteLine(item.TotalPrice());
            Console.WriteLine(item.ShippingLabel());
        }
    }
}