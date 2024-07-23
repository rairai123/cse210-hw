public class Customer
{
    private string _name;

    public Customer(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void DisplayName()
    {
        Console.WriteLine($"Customer Name: {_name}");
    }
}