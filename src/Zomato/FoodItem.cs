namespace Zomato;

public class FoodItem
{
    public string Name { get; }
    public string Id { get; }
    public string Description { get; }
    public int Cost { get; private set; }

    public FoodItem(string name, string id, string description, int cost)
    {
        Name = name;
        Id = id;
        Description = description;
        Cost = cost;
    }

    public void UpdatePrice(int cost) => Cost = cost;
}
