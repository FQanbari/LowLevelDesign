namespace LibraryManagementSystem;

public class User
{
    private static int userCount = 1;
    public string Name { get; private set; }
    public string Address { get; private set; }
    public string Email { get; private set; }
    public string Phone { get; private set; }
    public int UserId { get; private set; }

    public User(string name, string address, string email, string phone)
    {
        Name = name;
        Address = address;
        Email = email;
        Phone = phone;
        UserId = userCount++;
    }
}
