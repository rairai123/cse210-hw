public class Address
{

    public string _address;
    public string _city;
    public string _state;
    public string _country;


    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public Address()
    {}
    public string Stringify()
    {
        return $"{_address}\n{_city} {_state} {_country}";
    }

    public string returnCountry()
    {
        return _country;
    }
}