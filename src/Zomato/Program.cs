// Create an address
using Zomato;

Address customerAddress = new Address("123 Main St", "Tehran", "Tehran", "12345", "Iran");
Address deliveryAddress = new Address("456 Elm St", "Tehran", "Tehran", "54321", "Iran");
Address branchAddress = new Address("789 Food Ave", "Tehran", "Tehran", "98765", "Iran");

// Create a customer and delivery guy
Customer customer = new Customer("Ali Rezaei", "ali@gmail.com", "09123456789", customerAddress);
DeliveryGuy deliveryGuy = new DeliveryGuy("Hassan Mohammadi", "hassan@gmail.com", "09129876543", deliveryAddress);

// Create a restaurant with a branch
Branch branch = new Branch(branchAddress, "Downtown Branch");
Restaurant restaurant = new Restaurant("Tasty Foods", branch);

// Create a menu and add food items
Menu menu = new Menu("menu1");
FoodItem pizza = new FoodItem("Pizza", "f1", "Cheese Pizza", 150000);
FoodItem burger = new FoodItem("Burger", "f2", "Beef Burger", 100000);
menu.AddFood(pizza);
menu.AddFood(burger);

// Create an order
Order order = new Order("ord1", customer, deliveryGuy, DateTime.Now, PaymentMethod.Card);
order.AddMeal(pizza);
order.AddMeal(burger);

// Add order to customer and delivery guy
customer.AddOrder(order);
deliveryGuy.AddDelivery(order);

// Initialize the system and add details
OrderSystem system = new OrderSystem();
system.AddCustomerDetails(customer, order);
system.AddDeliveryDetails(deliveryGuy, order);

// Display order details
Console.WriteLine($"Customer: {customer.Name}");
Console.WriteLine($"Order ID: {order.OrderId}");
Console.WriteLine("Ordered Items:");
foreach (var item in order.Meal)
{
    Console.WriteLine($"- {item.Name}: {item.Cost} IRR");
}
Console.WriteLine($"Total Cost: {order.Meal.Sum(item => item.Cost)} IRR");
Console.WriteLine($"Delivery by: {order.Delivery.Name}");
Console.WriteLine($"Payment Method: {order.BillingMode}");

// Simulate delivery process
bool delivered = deliveryGuy.DeliverItem(order);
Console.WriteLine($"Delivery Status: {(delivered ? "Delivered" : "Not Delivered")}");

bool received = customer.ReceiveOrder(order);
Console.WriteLine($"Receive Status: {(received ? "Received" : "Not Received")}");

// Check system records
var customerOrders = system.GetCustomerDetails(customer);
Console.WriteLine($"\nCustomer Orders Remaining: {customerOrders.Count}");
var deliveryOrders = system.GetDeliveryDetails(deliveryGuy);
Console.WriteLine($"Delivery Guy Orders Remaining: {deliveryOrders.Count}");