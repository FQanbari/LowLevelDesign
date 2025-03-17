namespace CarRentalSystem;

public enum AccountStatus
{
    Active,
    Closed,
    Cancelled,
    Blacklisted,
    Blocked
}
public class Account
{
    public string Id { get; set; }
    public string Password { get; set; }
    public Person Person { get; set; }
    public AccountStatus Status { get; set; }

    public Account(string id, string password, Person person, AccountStatus status)
    {
        Id = id;
        Password = password;
        Person = person;
        Status = status;
    }

    public void ResetPassword()
    {
        Password = "";
    }
}
public class Member : Account
{
    public int TotalVehicles { get; set; }

    public Member(string id, string password, Person person, AccountStatus status, int totalVehicles)
        : base(id, password, person, status)
    {
        TotalVehicles = totalVehicles;
    }
}
public class Receptionist : Account
{
    public DateTime JoiningDate { get; set; }

    public Receptionist(string id, string password, Person person, AccountStatus status)
        : base(id, password, person, status)
    {
        JoiningDate = DateTime.Now;
    }
}