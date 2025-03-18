namespace Facebook;

public class Message
{
    public string MessageId { get; set; }
    public string Text { get; set; }
    public string Media { get; set; }
    public Member SentTo { get; set; }
    public Member SentFrom { get; set; }

    public Message(string messageId, string text, string media, Member sentTo, Member sentFrom)
    {
        MessageId = messageId;
        Text = text;
        Media = media;
        SentTo = sentTo;
        SentFrom = sentFrom;
    }

    public string GetText() => Text;
    public string GetMedia() => Media;
}
