namespace AirlineSystem;

public enum AccountStatus
{
    Active,
    Closed,
    Canceled,
    Blacklisted,
    Blocked
}
public class Account
{
    public string Id { get; set; }
    public string Password { get; set; }
    public AccountStatus Status { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public Passport Passport { get; set; }

    public Account(string id, string password, string name, string email, string phone, Passport passport)
    {
        Id = id;
        Password = password;
        Status = AccountStatus.Active; // مقدار پیش‌فرض
        Name = name;
        Email = email;
        Phone = phone;
        Passport = passport;
    }
}
public class Customer : Account
{
    public bool FrequentFlyer { get; set; }

    public Customer(string id, string password, string name, string email, string phone, Passport passport)
        : base(id, password, name, email, phone, passport)
    {
    }

    public Customer(string id, string password, string name, string email, string phone, Passport passport, bool frequentFlyer)
        : base(id, password, name, email, phone, passport)
    {
        FrequentFlyer = frequentFlyer;
    }

}
public class Staff : Account
{
    public Staff(string id, string password, string name, string email, string phone, Passport passport)
        : base(id, password, name, email, phone, passport)
    {
    }

    public void AddAircraft()
    {
        // پیاده‌سازی در آینده
    }

    public void AddFlight()
    {
        // پیاده‌سازی در آینده
    }
}