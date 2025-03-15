namespace EcommercePlatform;

public abstract class User
{
    public User(string name, string phone,string? username = null, string? password = null, string? address = null)
    {
        Name = name;
        Phone = phone;
        Address = address;
    }

    public string Name { get; }
    public string? Address { get; }
    public string Phone { get; }

    public override string ToString()
    {
        return $"User{{name='{Name}', phone='{Phone}'}}";
    }
}

public class Seller : User
{
    private List<Product> _products;

    public Seller(string name, string phone) : base(name, phone)
    {
        _products = new List<Product>();
    }

    public void RegisterProduct(ProductsCatalog productsCatalog, Product product)
    {
        product.Seller = this;
        productsCatalog.AddProduct(product);
        _products.Add(product);
    }

    public void UpdateProductQuantity(ProductsCatalog productsCatalog, Product product, int newQuantity)
    {
        productsCatalog.UpdateProductQuantity(product, newQuantity);
    }

    public void RemoveProduct(ProductsCatalog productsCatalog, Product product)
    {
        productsCatalog.RemoveProduct(product);
        _products.Remove(product);
    }

    public override string ToString()
    {
        return "Seller{}" + base.ToString();
    }
}

public class Customer : User
{
    private Cart _cart;

    public Customer(string name, string phone) : base(name, phone)
    {
        _cart = new Cart();
        OrderHistory = new List<Order>();
        CurrentOrder = new Order();
    }
    private List<Order> OrderHistory { get; set; }
    public Order CurrentOrder { get; }


    public void AddItemToCart(Item item)
    {
        this._cart.AddItem(item);
    }

    public void RemoveItemFromCart(Item item)
    {
        this._cart.RemoveItem(item);
    }

    public void PrintCartItems()
    {
        Console.WriteLine(string.Join(", ", this._cart.ItemList));
    }

    public void UpdateItemCount(Item item, int newQuantity)
    {
        this._cart.UpdateItemCount(item, newQuantity);
    }

    public void PlaceOrder()
    {

        CurrentOrder.OrderStatus = OrderStatus.Unshipped;
        CurrentOrder.OrderDate = DateTime.Now;
        List<Item> orderedItems = this._cart.ItemList;
        double orderAmount = 0;
        foreach (Item item in orderedItems)
        {
            orderAmount += item.Price;
        }
        CurrentOrder.SetItems(orderedItems);
        CurrentOrder.Amount = orderAmount;
        CurrentOrder.ShippingAddress = this.Address ?? "";
        this._cart.Checkout();
        OrderHistory.Add(CurrentOrder);
        Console.WriteLine("Checkout...");
    }
}