namespace LibraryManagementSystem;

public class Book
{
    private static int count = 1;
    public string Title { get; }
    public string Subject { get; }
    public string Author { get; }
    public string Publisher { get; }
    public int ID { get; }

    public Book(string title, string subject, string author, string publisher)
    {
        Title = title;
        Subject = subject;
        Author = author;
        Publisher = publisher;
        ID = count++;
    }
}
