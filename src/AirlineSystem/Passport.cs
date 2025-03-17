namespace AirlineSystem;

public class Passport
{
    public string PassportNumber { get; set; }
    public string Dob { get; set; }
    public Address Address { get; set; }
    public string ExpiryDate { get; set; }

    public Passport(string passportNumber, string dob, Address address, string expiryDate)
    {
        PassportNumber = passportNumber;
        Dob = dob;
        Address = address;
        ExpiryDate = expiryDate;
    }
}
