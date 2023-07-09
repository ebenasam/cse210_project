class Customer
{
    private string _customerName;
    private Address _customerAddress;
    private bool _isUSAAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
        SetUSAAddress();
    }

    public void SetUSAAddress()
    {
        _isUSAAddress = _customerAddress.GetIsUSAAddress();
    }

    public bool GetIsUSAAddress()
    {
        return _isUSAAddress;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return _customerAddress.GetStreetAddress();
    }
}