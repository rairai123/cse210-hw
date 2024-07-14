
using System;

class Program
{
    static void Main(string[] args)
    {
        //float x = 0;
        List<float> total = new List<float>();
        Order order = new Order();
        Address address1 = new Address("1234 Maple Street", "Springfield", "IL", "USA");
        Address address2 = new Address("Rua das Flores, 123", "São Paulo", "SP", "Brazil");
        Product product = new Product("Banana",1,5,5);
        Product product1 = new Product("Beans",2,4,2);
        Product product2 = new Product("Mixed Nuts",3,3,2);
        Product product3 = new Product("Bread",4,2,3);
        Product product4 = new Product("Milk",5,15,2);
        Product product5 = new Product("Hand Soap",6,3,1);
        Customer customer = new Customer("Maura dos Santos");
        Customer customer1 = new Customer("");
        customer.displayName();
        Console.WriteLine("-------------------------------------------");
        order.productAmount(product);
        order.productAmount(product1);
        order.productAmount(product2);
        order.displayProduct();
        order.priceList(product.Price());
        order.priceList(product1.Price());
        order.priceList(product2.Price());
        Console.WriteLine();
        order.getCountry(address1.returnCountry());
        order.Tot();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.packingLabel(customer.GetName(),product.getID()));
        Console.WriteLine(order.packingLabel(customer.GetName(),product1.getID()));
        Console.WriteLine(order.packingLabel(customer.GetName(),product2.getID()));
        Console.WriteLine();
        Console.WriteLine(order.shippingLabel(customer.GetName(), address1));
        Console.WriteLine("-------------------------------------------");
        Order order1 = new Order();
        Console.WriteLine();
        customer1.displayName();
        Console.WriteLine("-------------------------------------------");
        order1.productAmount(product3);
        order1.productAmount(product4);
        order1.productAmount(product5);
        order1.displayProduct();
        order1.priceList(product3.Price());
        order1.priceList(product4.Price());
        order1.priceList(product5.Price());
        Console.WriteLine();
        order1.getCountry(address2.returnCountry());
        order1.Tot();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.packingLabel(customer1.GetName(),product3.getID()));
        Console.WriteLine(order1.packingLabel(customer1.GetName(),product4.getID()));
        Console.WriteLine(order1.packingLabel(customer1.GetName(),product5.getID()));
        Console.WriteLine();
        Console.WriteLine(order1.shippingLabel(customer1.GetName(), address2));
        Console.WriteLine("-------------------------------------------");
    }
}
