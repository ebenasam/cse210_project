class Order
{
    private List<Product> _productsList = new List<Product>();
    private Customer _customer;
    private bool _isUSAAddress = true;
    private float _sumOfProductPrices = 0;
    private float _shippingCost = 0;
    private float _totalPrice = 0;

    public Order(List<Product> productsList, Customer customer)
    {
        _productsList = productsList;
        _customer = customer;
        _isUSAAddress = _customer.GetIsUSAAddress();
        GetTotalPrice();
    }

    private void GetTotalPrice()
    {
        CalculateSumOfProductPrices();
        CalculateShipping();
        _totalPrice = _shippingCost + _sumOfProductPrices;
    }
    private void CalculateSumOfProductPrices()
    {
        foreach (Product p in _productsList)
        {
            _sumOfProductPrices += p.GetTotalPrice();
        }
    }

    private void CalculateShipping()
    {
        switch (_isUSAAddress)
        {
            case true:
                _shippingCost = 5;
                break;
            case false:
                _shippingCost = 35;
                break;
        }
    }

    public string GetShippingLabel()
    {
        string shippingLabel;
        shippingLabel = $"_________________________________________________________________\nSHIPPING LABEL\n_________________________________________________________________\n{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}";
        return shippingLabel;
    }

    public List<string> GetPackingLabel()
    {
        List<string> packingLabel = new List<string>();
        packingLabel.Add("_________________________________________________________________\nPACKING LABEL\n_________________________________________________________________");
        foreach (Product p in _productsList)
        {
            packingLabel.Add($"{p.GetPackingLabel()}");
        }
        return packingLabel;
    }

    public string GetFinalBillLabel()
    {
        string total = $"_________________________________________________________________\nPAYMENT INFORMATION\n_________________________________________________________________\nItem(s) Subtotal: \t${_sumOfProductPrices:F2}\nShipping & Handling:  \t${_shippingCost:F2}\nGrand Total:  \t\t${_totalPrice:F2}";
        return total;
    }
}