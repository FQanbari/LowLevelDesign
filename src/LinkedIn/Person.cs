namespace LinkedIn;

public class Person
{
    public string Name { get; }
    public string Email { get; }
    public string Phone { get; }

    public Person(string name, string email, string phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
    }
}
