public class Order
{
    List<Product> products = new List<Product>();
    Product pro = new Product();
    public List<float> order = new List<float>();
    Address add = new Address();
    Product product = new Product();

    public void productAmount(Product product)
    {
        products.Add(product);
    }

    public void displayProduct()
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"Product name: {product._name}\nQuantity: {product._quantity}\nPrice: ${product._price}");
        }
    }
    
    
    public void priceList(float _total)
    {
        order.Add(_total);
    }

    public void Tot()
    {
        Console.WriteLine($"Total price after shipping fee: ${order.Sum()}");
    }

    public void getCountry(string _country)
    {
        if(_country.ToUpper() == "USA")
        {
            Console.WriteLine("Shipping fee within the USA is $5");
            order.Add(5);
        }
        else
        {
            Console.WriteLine("Shipping fee outside of the USA is $35");
            order.Add(35);
        }
    }
    
    public string packingLabel(string _name, int _id)
    {
        return $"Name: {_name}, product ID: {_id}";
    }
    public string shippingLabel(string _name, Address address)
    {
        return $"Shipping Label:\nName: {_name}\nAddress: {address._address},\n{address._city}, {address._state}, {address._country}";
    }

    
}