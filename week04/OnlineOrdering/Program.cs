using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address address1 = new Address("123 Maple St", "Springfield", "IL", "USA");
        Address address2 = new Address("Sithole St", "Accra", "Greater Accra", "Ghana");

        // Create customers
        Customer customer1 = new Customer("Prince Eli", address1);
        Customer customer2 = new Customer("Janis Kruppa", address2);

        // Create products
        Product product1 = new Product("Laptop", "P001", 1000, 1);
        Product product2 = new Product("Mouse", "P002", 50, 2);
        Product product3 = new Product("Mouse Pad", "P003", 5, 2);
        Product product4 = new Product("Monitor", "P004", 200, 2);
        Product product5 = new Product("Desktop", "P005", 750, 2);
        Product product6 = new Product("Charger", "P006", 100, 2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}
