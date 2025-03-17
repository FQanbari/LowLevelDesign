namespace LiveCricketCommentary;

// Commentator.cs
public class Commentator
{
    public string Name { get; set; }
    public Commentary Commentary { get; set; }

    public Commentator(string name)
    {
        Name = name;
    }
}
