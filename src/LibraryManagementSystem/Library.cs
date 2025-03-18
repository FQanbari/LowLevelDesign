namespace LibraryManagementSystem;

public class Library
{
    public string Name { get; private set; }
    public string Address { get; private set; }

    public Library(string name, string address)
    {
        Name = name;
        Address = address;
    }
}
