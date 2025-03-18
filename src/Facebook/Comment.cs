namespace Facebook;

public class Comment
{
    public string CommentId { get; set; }
    public string Text { get; set; }
    public int TotalLikes { get; set; }
    public Member Owner { get; set; }

    public Comment(string commentId, string text, Member owner)
    {
        CommentId = commentId;
        Text = text;
        Owner = owner;
    }

    public void AddLike()
    {
        TotalLikes++;
    }
}