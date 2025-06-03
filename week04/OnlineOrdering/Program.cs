class Program
{
    static void Main()
    {
        Address address1 = new Address("Box 12", "Ashanti", "Kumasi", "Ghana");
        Customer customer1 = new Customer("Kotu Addae", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Cocoa", "local", 110, 3));
        order1.AddProduct(new Product("choko", "milo", 30, 4));

        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotal()}");
    }
}