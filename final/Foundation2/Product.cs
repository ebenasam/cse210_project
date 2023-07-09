class Product
{
    private string _productName;
    private string _productID;
    private float _productPrice;
    private float _totalProductPrice;
    private int _quantity;

    public Product(string productName, string productID, float productPrice, int quanity)
    {
        _productName = productName;
        _productID = productID;
        _productPrice = productPrice;
        _quantity = quanity;
        CalculateTotalProductPrice();
    }

    private void CalculateTotalProductPrice()
    {
        _totalProductPrice = _productPrice * _quantity;
    }

    public float GetTotalPrice()
    {
        return _totalProductPrice;
    }

    public string GetPackingLabel()
    {
         return $"{_quantity}\tof {_productName}\t-\t{_productID}\t-\t${_productPrice:F2} each";
    }
    
}