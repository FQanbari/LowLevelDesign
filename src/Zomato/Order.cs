namespace Zomato;

public enum PaymentMethod
{
    Cash,
    UPI,
    Card,
    NetBanking
}
public class Order
{
    public string OrderId { get; }
    public Customer Customer { get; }
    public DeliveryGuy Delivery { get; }
    public DateTime CreationOrder { get; }
    public PaymentMethod BillingMode { get; }
    public List<FoodItem> Meal { get; } = new List<FoodItem>();

    public Order(string orderId, Customer customer, DeliveryGuy delivery,
        DateTime creationOrder, PaymentMethod billingMode)
    {
        OrderId = orderId;
        Customer = customer;
        Delivery = delivery;
        CreationOrder = creationOrder;
        BillingMode = billingMode;
    }

    public void AddMeal(FoodItem dish) => Meal.Add(dish);
}
