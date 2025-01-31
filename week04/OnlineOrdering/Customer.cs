public class Customer{
    private string _fullName;
    private Address _address;

    public Customer(string fullName, Address address)
    {
        _fullName = fullName;
        _address = address;
    }

    public string GetFullName()
    {
        return _fullName;
    }

    public string GetFinalAddress()
    {
        return _address.GetAddress();
    }
    public Boolean LiveInUSA()
    {
        return _address.USAOrNot();
    }
}