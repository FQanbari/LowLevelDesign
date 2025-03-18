namespace Facebook;

public enum RequestStatus
{
    Pending,
    Accepted,
    Rejected
}
public class FriendRequest
{
    public Member RequestFrom { get; set; }
    public Member RequestTo { get; set; }
    public RequestStatus Status { get; set; }
    public DateTime Created { get; set; }
    public DateTime Updated { get; set; }

    public FriendRequest(Member requestFrom, Member requestTo)
    {
        RequestFrom = requestFrom;
        RequestTo = requestTo;
        Created = DateTime.Now;
        Status = RequestStatus.Pending;
    }

    public void Accept()
    {
        Status = RequestStatus.Accepted;
        Updated = DateTime.Now;
        RequestFrom.Following.Add(RequestTo);
        RequestTo.Followers.Add(RequestFrom);
    }

    public void Reject()
    {
        Status = RequestStatus.Rejected;
        Updated = DateTime.Now;
    }
}
