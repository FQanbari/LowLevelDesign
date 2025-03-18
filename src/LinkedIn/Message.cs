namespace LinkedIn;

public class Message
{
    public string MessageId { get; }
    public string Text { get; }
    public string Media { get; }
    public Member SentTo { get; }

    public Message(string messageId, string text, string media, Member sentTo)
    {
        MessageId = messageId;
        Text = text;
        Media = media;
        SentTo = sentTo;
    }
}
