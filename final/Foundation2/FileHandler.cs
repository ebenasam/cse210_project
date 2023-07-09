class FileHandler
{
    private string _filename;
    private List<Order> _orders = new List<Order>();
    private string _csvDelimiter = "||";
    public FileHandler(string filename)
    {
        _filename = filename;
        ReadFile();
    }

    public void ReadFile()
    {
        using (StreamReader reader = new StreamReader(_filename))
        {
            string line;
            string[] lineList;

            while ((line = reader.ReadLine()) != null)
            {

                lineList = line.Split(_csvDelimiter);  

                List<Product> products = new List<Product>();
                Address address = new Address(lineList[1]);
                Customer customer = new Customer(lineList[0],address);

                if (lineList.Count()>2)
                {
                    for (int i = 2; i< lineList.Count()-1; i++)
                    {
                        string ProductName = lineList[i];
                        string ProductID = lineList[i+1];
                        float ProductPrice = float.Parse(lineList[i+2]);
                        int ProductQuantity = int.Parse(lineList[i+3]);

                        Product product = new Product(ProductName, ProductID, ProductPrice, ProductQuantity);
                        products.Add(product);
                        i+=3;
                    }
                }

                Order order = new Order(products,customer);
                _orders.Add(order);
            }
        }
    }
    public List<Order> GetOrders()
    {
        return _orders;
    }
}