namespace task_4;

public class Order
{
    public int OrderNumber;
    public string ProductName;
    public int Quantity;
    public decimal TotalAmount;

    public Order(int orderNumber, string productName, int productQuantity, decimal orderAmount)
    {
        OrderNumber = orderNumber;
        ProductName = productName;
        Quantity = productQuantity;
        TotalAmount = orderAmount;
    }
    public Order(string productName, int productQuantity)
    {
        ProductName = productName;
        Quantity = productQuantity;
    }
    public Order(string productName, decimal orderAmount)
    {
        ProductName = productName;
        TotalAmount = orderAmount;
    }

    public void DisplayInfo()
    {
        if (OrderNumber != 0)
        {
            System.Console.WriteLine(OrderNumber + " ");
        }
        if (ProductName != null)
        {
            System.Console.WriteLine(ProductName + " ");
        }
        if (Quantity != 0)
        {
            System.Console.WriteLine(Quantity + " ");
        }
        if (TotalAmount != 0)
        {
            System.Console.WriteLine(TotalAmount + " ");
        }
    }




}