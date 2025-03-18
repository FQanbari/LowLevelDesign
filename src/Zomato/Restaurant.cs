namespace Zomato;

public class Restaurant
{
    public string Name { get; }
    public List<Branch> Branches { get; } = new List<Branch>();

    public Restaurant(string name, Branch initialBranch)
    {
        Name = name;
        Branches.Add(initialBranch);
    }

    public void AddBranch(Branch branch) => Branches.Add(branch);
}
