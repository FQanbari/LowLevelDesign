namespace Facebook;

public enum AccountStatus
{
    Active,
    Closed,
    Canceled,
    Blacklisted,
    Disabled
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

    public void ResetPassword(string newPassword = "")
    {
        Password = newPassword;
    }
}
public class Member : Account
{
    public int MemberId { get; set; } // از "Id" به "MemberId" تغییر دادم تا با Id پایه تداخل نکنه
    public List<Member> Following { get; set; } = new List<Member>();
    public List<Member> Followers { get; set; } = new List<Member>();
    public List<Page> PagesFollow { get; set; } = new List<Page>();

    public Member(string id, string password, Person person, AccountStatus status, int memberId)
        : base(id, password, person, status)
    {
        MemberId = memberId;
    }

    public Message SendMessage(string messageId, string text, string media, Member sentTo)
    {
        return new Message(messageId, text, media, sentTo, this);
    }

    public Post CreatePost(string postId, string text)
    {
        return new Post(this, postId, text);
    }

    public FriendRequest SendRequest(Member toMember)
    {
        return new FriendRequest(this, toMember);
    }
}
public class AdminSystem : Account
{
    public AdminSystem(string id, string password, Person person, AccountStatus status)
        : base(id, password, person, status)
    {
    }

    public void BlockMember(Member member)
    {
        member.Status = AccountStatus.Disabled;
    }

    public void UnblockMember(Member member)
    {
        member.Status = AccountStatus.Active;
    }
}