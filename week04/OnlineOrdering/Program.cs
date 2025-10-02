using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1 Setup ---
        Order order1 = new Order();
        Customer customer1 = new Customer("Alice Johnson", "alice@example.com", "555-1234", new Address("123 Main St", "Springfield", "IL", "USA"));
        order1.SetCustomer(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50, 2));

        // --- Order 2 Setup ---
        Order order2 = new Order();
        Customer customer2 = new Customer("Bob Smith", "bob@example.com", "555-5678", new Address("456 Elm St", "Toronto", "ON", "Canada"));
        order2.SetCustomer(customer2);

        order2.AddProduct(new Product("Smartphone", "P003", 699.99, 1));
        order2.AddProduct(new Product("Headphones", "P004", 89.99, 1));

        // --- Output ---
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order2.GetPackingLabel());

        // Corrected variable casing (order1/order2) and used the Customer object set earlier.
        Console.WriteLine(order1.GetShippingLabel(customer1));
        Console.WriteLine(order2.GetShippingLabel(customer2));

        Console.WriteLine($"Order 1 Total Price (with shipping): ${order1.CalculateTotalPriceWithShipping():F2}");
        Console.WriteLine($"Order 2 Total Price (with shipping): ${order2.CalculateTotalPriceWithShipping():F2}");
    }
}