class Address
{
    private string _streetAddress;
    private string _country;
    private bool _isUSAAddress;

    public Address(string _streetAddress)
    {
        BuildAddressFormat(_streetAddress);
        SetCountryBoolean();
    }

    private void BuildAddressFormat(string streetAddress)
    {
        string[] address = streetAddress.Split(",");
        _country = address[3].Trim();
        _streetAddress = $"{address[0].Trim()},\n{address[1].Trim()}, {address[2].Trim()} {address[3].Trim()}\n{_country.Trim()}";
    }

    private void SetCountryBoolean()
    {
        if (_country.Contains("USA") || ("USA".Contains(_country)))
        {
            _isUSAAddress = true;
        }
        else
        {
            _isUSAAddress = false;
        }
    }
    public bool GetIsUSAAddress()
        {
            return _isUSAAddress;
        }
    public string GetStreetAddress()
    {
        return $"{_streetAddress}";
    }
}