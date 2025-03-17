namespace LiveCricketCommentary;

// Admin.cs
public class Admin
{
    public string Username { get; set; }
    public string Password { get; set; }

    public Admin(string username, string password)
    {
        Username = username;
        Password = password;
    }
}
