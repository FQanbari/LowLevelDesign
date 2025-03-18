namespace Zomato;

public class Menu
{
    public string MenuId { get; }
    public List<FoodItem> Items { get; } = new List<FoodItem>();

    public Menu(string id)
    {
        MenuId = id;
    }

    public void AddFood(FoodItem dish) => Items.Add(dish);
}
