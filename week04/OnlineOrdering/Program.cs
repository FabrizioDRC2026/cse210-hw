using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Phoenix", "Arizona", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM100", 25.99, 2));
        order1.AddProduct(new Product("Keyboard", "KB200", 45.50, 1));
        order1.AddProduct(new Product("USB Cable", "USB300", 8.75, 3));

        Address address2 = new Address("45 Paulista Avenue", "São Paulo", "SP", "Brazil");
        Customer customer2 = new Customer("Maria Silva", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Laptop Stand", "LS400", 35.00, 1));
        order2.AddProduct(new Product("Webcam", "WC500", 79.99, 2));
        order2.AddProduct(new Product("Notebook", "NB600", 12.50, 4));

        Console.WriteLine("=====================================");
        Console.WriteLine("Order 1");
        Console.WriteLine("=====================================");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.GetTotalCost():0.00}");

        Console.WriteLine();

        Console.WriteLine("=====================================");
        Console.WriteLine("Order 2");
        Console.WriteLine("=====================================");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.GetTotalCost():0.00}");
    }
}