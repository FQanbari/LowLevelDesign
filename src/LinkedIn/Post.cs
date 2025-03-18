namespace LinkedIn;

public class Post
{
    public Member Owner { get; }
    public string PostId { get; }
    public string Text { get; }
    public int TotalLikes { get; private set; }
    public int TotalShares { get; private set; }

    public Post(Member owner, string postId, string text)
    {
        Owner = owner;
        PostId = postId;
        Text = text;
        TotalLikes = 0;
        TotalShares = 0;
    }

    public void AddLike() => TotalLikes++;
}
