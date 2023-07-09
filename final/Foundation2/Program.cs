using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string filename = "CustomerInfoCSV.txt";
        
        List<Order> orders = new List<Order>();
        FileHandler filehandler = new FileHandler(filename);
        orders = filehandler.GetOrders();

        DisplayLabels(orders);
    }
    static void DisplayLabels(List<Order> orders)
    {
        int orderNum = 0;
        foreach (Order o in orders)
        {
            orderNum +=1;
            Console.WriteLine("\n");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine($"Order Number: {orderNum}");

            List<string> packingLabels = o.GetPackingLabel();
            foreach (string p in packingLabels)
            {
                Console.WriteLine($"{p}");
            }
    
            Console.WriteLine(o.GetShippingLabel());
            Console.WriteLine(o.GetFinalBillLabel());
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        }
        Console.WriteLine();
    }
}