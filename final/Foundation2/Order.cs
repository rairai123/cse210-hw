public class Order
{
    private List<Product> _products = new List<Product>();
    private float _total = 0;

    public void AddProduct(Product product)
    {
        _products.Add(product);
        _total += product.CalculatePrice();
    }

    public void DisplayProducts()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product name: {product.GetName()}\nQuantity: {product.GetQuantity()}\nPrice: ${product.GetPrice()}");
        }
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public void CalculateShipping(string country)
    {
        if (country.ToUpper() == "USA")
        {
            Console.WriteLine("Shipping fee within the USA is $5");
            _total += 5;
        }
        else
        {
            Console.WriteLine("Shipping fee outside of the USA is $35");
            _total += 35;
        }
    }

    public void DisplayTotal()
    {
        Console.WriteLine($"Total price after shipping fee: ${_total}");
    }

    public string CreatePackingLabel(string customerName, int productId)
    {
        return $"Name: {customerName}, product ID: {productId}";
    }

    public string CreateShippingLabel(string customerName, Address address)
    {
        return $"Shipping Label:\nName: {customerName}\nAddress: {address.Stringify()}";
    }
}