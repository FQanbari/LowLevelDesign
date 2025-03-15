using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EcommercePlatform;

public enum OrderStatus
{
    Created,
    Pending,
    Unshipped,
    Shipped,
    Cancelled,
    Completed
}
public class Order
{
    private static int numberCounter = 0;
    private int _orderNumber;
    private OrderStatus _orderStatus;
    private List<Item> _items;
    private string _shippingAddress;
    private List<OrderLog> _orderLogs;

    public Order()
    {
        numberCounter += 1;
        _orderNumber = numberCounter;
        _orderLogs = new List<OrderLog>();
        AddOrderLog(new OrderLog(DateTime.Now, OrderStatus.Created));
    }
    public DateTime OrderDate { get; set; }
    public OrderStatus OrderStatus
    {
        get => _orderStatus;
        set
        {
            _orderStatus = value;
            AddOrderLog(new OrderLog(DateTime.Now, value)); 
        }
    }
    public double Amount { get; set; }  
    public string ShippingAddress { get; set; }
    
    public Shipment MoveToShipment()
    {
        Shipment shipment = new Shipment(this);
        return shipment;
    }
    private void AddOrderLog(OrderLog orderLog)
    {
        _orderLogs.Add(orderLog);
    }
    public void SetItems(List<Item> items)
    {
       _items = new List<Item>(items);
    }

    public override string ToString()
    {
        return $"Order{{orderNumber={_orderNumber}, orderStatus={OrderStatus}, orderDate={OrderDate}, items={string.Join(", ", _items)}, amount={Amount}, shippingAddress='{_shippingAddress}'}}";
    }
    public void PrintOrderLog()
    {
        Console.WriteLine("\n📜 Order Logs\n");
        foreach (var log in _orderLogs)
        {
            Console.WriteLine(log);
            Console.WriteLine(new string('-', 30));
        }
    }
}
public class Shipment
{
    private static int numberCounter = 0;
    private int _shipmentNumber;
    private DateTime _date;
    private DateTime _estimatedArrival;
    private Order _orderDetails;

    public Shipment(Order orderDetails)
    {
        numberCounter += 1;
        _shipmentNumber = numberCounter;
        _date = DateTime.Now;
        _estimatedArrival = _date.AddDays(3);
        _orderDetails = orderDetails;
        orderDetails.OrderStatus = OrderStatus.Shipped;
    }

    public override string ToString()
    {
        return $"Shipment{{_shipmentNumber={_shipmentNumber}, _date={_date}, _estimatedArrival={_estimatedArrival}, _orderDetails={_orderDetails}}}";
    }
    public void PrintOrderLog()
    {
        _orderDetails.PrintOrderLog();
    }
}
public class OrderLog
{
    private DateTime _creationTimestamp;
    private OrderStatus _status;

    public OrderLog(DateTime creationTimestamp, OrderStatus status)
    {
        _creationTimestamp = creationTimestamp;
        _status = status;
    }
    public override string ToString() 
    {
        return $"📅 Date: {_creationTimestamp:yyyy-MM-dd HH:mm:ss} - 📌 Status: {_status}";
    }   
}