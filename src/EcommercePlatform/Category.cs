namespace EcommercePlatform;

public class Category
{
    public string Name { get; }
    public string? Description { get; }

    public Category(string name, string? description = null)
    {
        Name = name;
        Description = description;
    }
}
