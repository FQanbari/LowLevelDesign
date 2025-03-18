namespace Facebook;

public class Page
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Id { get; set; }
    public List<Member> Members { get; set; } = new List<Member>();

    public Page(string name, string description, string id)
    {
        Name = name;
        Description = description;
        Id = id;
    }

    public int GetTotalMember() => Members.Count;
}
