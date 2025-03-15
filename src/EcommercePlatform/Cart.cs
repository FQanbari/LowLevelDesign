namespace EcommercePlatform;

public class Cart
{
    public Cart()
    {
        ItemList = new List<Item>();
    }
    public List<Item> ItemList { get; private set; }

    public void AddItem(Item item)
    {
        ItemList.Add(item);
    }

    public void RemoveItem(Item item)
    {
        ItemList.Remove(item);
    }

    public void UpdateItemCount(Item item, int newCount)
    {
        int index = ItemList.IndexOf(item);
        ItemList[index].UpdateCount(newCount);
    }
    public void Checkout()
    {
        ItemList.Clear();
    }
}

public class Item
{
    private int _productId;
    private string _productName;
    private int _count;

    public Item(Product product, int count)
    {
        _productId = product.Id;
        _productName = product.Name;
        _count = count;
        Price = product.Price * count;
    }

    public double Price { get; private set; }

    public override string ToString()
    {
        return $"Item{{product={_productId}:{_productName}, count={_count}, price={Price}}}";
    }

    public void UpdateCount(int newCount)
    {
        Price = (Price / _count) * newCount;
        _count = newCount;
    }
}