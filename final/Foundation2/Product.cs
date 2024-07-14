    public class Product
{

    public string _name;
    public int _id;
    public int _price;
    public int _quantity;
    public float _total;


    public Product(string name, int id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    
    public int getID()
    {
        return _id;
    }
    public Product(){}

    public float Price()
    {
        _total = _price * _quantity;
        return _total;
    }

}