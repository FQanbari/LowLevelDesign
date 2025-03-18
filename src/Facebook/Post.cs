namespace Facebook;

public class Post
{
    public Member Owner { get; set; }
    public string PostId { get; set; }
    public string Text { get; set; }
    public int TotalLikes { get; set; }
    public int TotalShares { get; set; }

    public Post(Member owner, string postId, string text)
    {
        Owner = owner;
        PostId = postId;
        Text = text;
    }

    public void AddLike()
    {
        TotalLikes++;
    }
}
