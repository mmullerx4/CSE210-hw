using System;

class Address{
    private string _streetAddress;
    private string _city;
    private string _provState;
    private string _country;


    public Address(string streetAddress, string city, string provState, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _provState = provState;
        _country = country;
        
    }

    public bool GetIsUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else{
            return false;
        }

    }

    public void fullAddress()
    {
        Console.WriteLine(_streetAddress);
        Console.WriteLine($"{_city}, {_provState}");
        Console.WriteLine(_country);
    }
}