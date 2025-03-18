namespace Zomato;

public class Branch
{
    public Address Address { get; }
    public string Name { get; }

    public Branch(Address address, string name)
    {
        Address = address;
        Name = name;
    }
}
