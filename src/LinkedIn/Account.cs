namespace LinkedIn;

public enum AccountStatus
{
    Active,
    Closed,
    Canceled,
    Blacklisted,
    Disabled
}
public abstract class Account
{
    public string Id { get; }
    protected string Password { get; set; }
    public Person Person { get; }
    public AccountStatus Status { get; set; }

    public Account(string id, string password, Person person, AccountStatus status)
    {
        Id = id;
        Password = password;
        Person = person;
        Status = status;
    }

    public void ResetPassword() => Password = "";
}
public class Member : Account
{
    public int MemberId { get; }
    public List<Member> Following { get; } = new List<Member>();
    public List<Member> Followers { get; } = new List<Member>();
    public List<Job> PagesFollow { get; } = new List<Job>();

    public Member(string id, string password, Person person, AccountStatus status, int memberId)
        : base(id, password, person, status)
    {
        MemberId = memberId;
    }

    public void SendMessage(string msg) { }

    public void CreatePost(Post post) { }

    public void SendRequest(Member member) { }
}

public class Recruiter : Account
{
    public Recruiter(string id, string password, Person person, AccountStatus status)
        : base(id, password, person, status)
    {
    }

    public void PostJob(Job job) { }

    public void CloseJob(Job job) { }
}