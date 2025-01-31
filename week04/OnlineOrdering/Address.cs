public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public Boolean USAOrNot()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        return false;
    }

    public string GetAddress()
    {
        string fullAdress = $"{_street}\n{_city}, {_stateProvince}\n{_country}";
        return fullAdress;
    }
}