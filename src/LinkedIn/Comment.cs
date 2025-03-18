namespace LinkedIn;

public class Comment
{
    public string CommentId { get; }
    public string Text { get; }
    public int TotalLikes { get; private set; }
    public Member Owner { get; }

    public Comment(string commentId, string text, Member owner)
    {
        CommentId = commentId;
        Text = text;
        Owner = owner;
        TotalLikes = 0;
    }

    public void AddLike() => TotalLikes++;
}
