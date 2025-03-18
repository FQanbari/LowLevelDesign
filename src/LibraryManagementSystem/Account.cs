namespace LibraryManagementSystem;

public abstract class Account
{
    public string Id { get; private set; }
    protected string Password { get; set; }
    public bool Status { get; private set; } = true;
    protected Credentials Credentials { get; set; }
    public User Person { get; private set; }

    public Account(string id, string password, User person)
    {
        Id = id;
        Password = password;
        Person = person;
        Credentials = new Credentials(id, password);
    }

    public void ResetPassword() => Password = "";
}
public class Librarian : Account
{
    public Librarian(string id, string pass, User person) : base(id, pass, person) { }

    public void AddBook(Book book, Catalog bookDatabase)
    {
        bookDatabase.UpdateBook(book);
        Console.WriteLine("Done");
    }

    public void RegisterUser() { }
}

public class Members : Account
{
    public int TotalBook { get; private set; } = 0;

    public Members(string id, string pass, User user) : base(id, pass, user) { }

    public void IssueBook(Book book) => TotalBook++;

    public void Renew(DateTime today)
    {
        BookLending.CreationDate = today;
        BookLending.DueDate = today;
    }
}