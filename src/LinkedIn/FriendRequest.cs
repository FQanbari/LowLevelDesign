namespace LinkedIn;

public enum RequestStatus
{
    Pending,
    Accepted,
    Rejected
}
public class FriendRequest
{
    public Member RequestFrom { get; }
    public Member RequestTo { get; }
    public RequestStatus Status { get; set; }
    public DateTime Created { get; }
    public DateTime Updated { get; set; }

    public FriendRequest(Member user1, Member user2)
    {
        RequestFrom = user1;
        RequestTo = user2;
        Created = DateTime.Now;
        Status = RequestStatus.Pending;
    }

    public void Accept() { }

    public void Reject() { }
}
