namespace Zomato;

public class Person
{
    public string Name { get; }
    public string Email { get; }
    public string Phone { get; }
    public Address Address { get; }

    public Person(string name, string email, string phone, Address address)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
    }
}
public class Customer : Person
{
    public List<Order> Orders { get; } = new List<Order>();

    public Customer(string name, string email, string phone, Address address)
        : base(name, email, phone, address)
    {
    }

    public void AddOrder(Order order) => Orders.Add(order);

    public bool ReceiveOrder(Order order)
    {
        if (!Orders.Contains(order))
            return false;

        Orders.Remove(order);
        return true;
    }
}
public class DeliveryGuy : Person
{
    public List<Order> Deliveries { get; } = new List<Order>();

    public DeliveryGuy(string name, string email, string phone, Address address)
        : base(name, email, phone, address)
    {
    }

    public void AddDelivery(Order order) => Deliveries.Add(order);

    public bool DeliverItem(Order order)
    {
        if (!Deliveries.Contains(order))
            return false;

        Deliveries.Remove(order);
        return true;
    }
}