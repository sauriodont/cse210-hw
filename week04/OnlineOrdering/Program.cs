
using System;
class Program
{
    static void Main(string[] args)
    {
        // Clientes
        Address address1 = new Address("123 Hawai St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Jane Doe", address1);

        Address address2 = new Address("45 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Carlos Silva", address2);

        // Pedidos
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "M100", 20.99, 2));
        order1.AddProduct(new Product("Wireless USB Adapter", "K200", 65.50, 1));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Bluetooth Earphones", "A300", 45.75, 1));
        order2.AddProduct(new Product("HDMI Screen 24\"", "M400", 129.99, 2));

        // Mostrar detalles de los pedidos
        List<Order> orders = new List<Order> { order1, order2 };
        foreach (var order in orders)
        {
            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine("\n Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine(new string('-', 40));
        }
    }
}