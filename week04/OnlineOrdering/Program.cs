using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("USB Cable", "P001", 5.99m, 3));
        order1.AddProduct(new Product("Keyboard", "P002", 25.50m, 1));

        // Order 2
        Address address2 = new Address("45 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Wireless Mouse", "P003", 15.00m, 2));
        order2.AddProduct(new Product("Laptop Stand", "P004", 30.00m, 1));
        order2.AddProduct(new Product("HDMI Cable", "P005", 8.25m, 2));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}\n");
    }
}
