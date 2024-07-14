public class Customer
{
    Address address = new Address("1234 Maple Street", "Springfield", "IL", "USA");
    public string _name;

    public Customer(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void displayName()
    {
        Console.WriteLine($"Customer Name: {_name}");
    }
    

    
}