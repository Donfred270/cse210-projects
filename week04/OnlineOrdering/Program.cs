using System;
namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
         // Create Address
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");

        // Create Customer
        Customer customer1 = new Customer("John Doe", address1);

        // Create Products
        Product product1 = new Product("Laptop", 101, 800, 1);
        Product product2 = new Product("Smartphone", 102, 600, 2);

        // Create Order
        List<Product> products = new List<Product> { product1, product2 };
        Order order1 = new Order(products, customer1);

        // Display order details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");
    }
}