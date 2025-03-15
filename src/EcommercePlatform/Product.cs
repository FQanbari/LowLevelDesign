namespace EcommercePlatform;

public class Product
{
    private static int idCounter = 0;

    public Product(string name, string description, double price, Category category, int availableCount)
    {
        idCounter += 1;
        Id = idCounter;
        Name = name;
        Description = description;
        Price = price;
        Category = category;
        AvailableCount = availableCount;
    }

    public int Id { get; }
    public string Name { get; }
    public string Description { get ; }
    public double Price { get ; }
    public double Ratings { get ; }
    public int AvailableCount { get; set; }

    public Category Category { get; }
    public Seller Seller { get; set; }

    public override string ToString()
    {
        return $"Product{{id={Id}, name='{Name}', description='{Description}', price={Price}, ratings={Ratings}, category={Category}, availableCount={AvailableCount}, seller={Seller}}}";
    }
}
