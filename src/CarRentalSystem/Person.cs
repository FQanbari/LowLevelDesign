namespace CarRentalSystem;

public class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Address Address { get; set; }

    public Person(string name, string email, string phone, Address address)
    {
        Name = name;
        Email = email;
        Phone = phone;
        Address = address;
    }
}
