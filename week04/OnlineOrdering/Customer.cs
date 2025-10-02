using System;
public class Customer
{
    private string _name;
    private string _email;
    private string _phoneNumber;
    private Address _address;

    public Customer(string name, string email, string phoneNumber, Address address)
    {
        _name = name;
        _email = email;
        _phoneNumber = phoneNumber;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetEmail()
    {
        return _email;
    }

    public string GetPhoneNumber()
    {
        return _phoneNumber;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public bool IsInUSA()
    {
        if (_address.IsInUSA())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}