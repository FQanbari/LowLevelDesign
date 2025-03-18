namespace LibraryManagementSystem;

public class Credentials
{
    private Dictionary<string, string> loginPass = new();

    public Credentials(string username, string password)
    {
        if (loginPass.ContainsKey(username))
        {
            Console.WriteLine("Invalid username already Exists");
        }
        else
        {
            loginPass[username] = password;
        }
    }

    public bool Login(string username, string password)
    {
        if (loginPass.TryGetValue(username, out string storedPass) && storedPass == password)
        {
            Console.WriteLine("Logged In Successfully");
            return true;
        }
        return false;
    }
}
