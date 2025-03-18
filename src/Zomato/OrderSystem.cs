using System;
using System.Collections.Generic;

namespace Zomato;

public enum OrderStatus
{
    Active,
    Closed,
    Canceled
}

public enum PaymentStatus
{
    Unpaid,
    Pending,
    Completed,
    Filled,
    Declined,
    Cancelled
}

public class OrderSystem
{
    private Dictionary<Customer, List<Order>> CustomerDB { get; } = new Dictionary<Customer, List<Order>>();
    private Dictionary<DeliveryGuy, List<Order>> DeliveryDB { get; } = new Dictionary<DeliveryGuy, List<Order>>();

    public void AddCustomerDetails(Customer user, Order order)
    {
        if (!CustomerDB.ContainsKey(user))
            CustomerDB[user] = new List<Order>();
        CustomerDB[user].Add(order);
    }

    public List<Order> GetCustomerDetails(Customer customer) =>
        CustomerDB.TryGetValue(customer, out var orders) ? orders : new List<Order>();

    public void AddDeliveryDetails(DeliveryGuy delivery, Order order)
    {
        if (!DeliveryDB.ContainsKey(delivery))
            DeliveryDB[delivery] = new List<Order>();
        DeliveryDB[delivery].Add(order);
    }

    public List<Order> GetDeliveryDetails(DeliveryGuy delivery) =>
        DeliveryDB.TryGetValue(delivery, out var orders) ? orders : new List<Order>();
}