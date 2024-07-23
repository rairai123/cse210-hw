using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Create a new order");
            Console.WriteLine("2. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                break;
            }
            else if (choice == "1")
            {
                CreateOrder();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static void CreateOrder()
    {
        Order order = new Order();
        Customer customer = CreateCustomer();
        Address address = CreateAddress();

        while (true)
        {
            Product product = CreateProduct();
            order.AddProduct(product);

            Console.Write("Add another product? (y/n): ");
            if (Console.ReadLine().ToLower() != "y")
                break;
        }

        Console.WriteLine("\nOrder Summary:");
        customer.DisplayName();
        Console.WriteLine("-------------------------------------------");
        order.DisplayProducts();
        Console.WriteLine();
        order.CalculateShipping(address.ReturnCountry());
        order.DisplayTotal();
        Console.WriteLine();
        Console.WriteLine("Packing Label:");
        foreach (var product in order.GetProducts())
        {
            Console.WriteLine(order.CreatePackingLabel(customer.GetName(), product.GetID()));
        }
        Console.WriteLine();
        Console.WriteLine(order.CreateShippingLabel(customer.GetName(), address));
    }

    static Customer CreateCustomer()
    {
        Console.Write("Enter customer name: ");
        return new Customer(Console.ReadLine());
    }

    static Address CreateAddress()
    {
        Console.Write("Enter street address: ");
        string street = Console.ReadLine();
        Console.Write("Enter city: ");
        string city = Console.ReadLine();
        Console.Write("Enter state: ");
        string state = Console.ReadLine();
        Console.Write("Enter country: ");
        string country = Console.ReadLine();

        return new Address(street, city, state, country);
    }

    static Product CreateProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter product ID: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Enter product price: ");
        int price = int.Parse(Console.ReadLine());
        Console.Write("Enter product quantity: ");
        int quantity = int.Parse(Console.ReadLine());

        return new Product(name, id, price, quantity);
    }
}