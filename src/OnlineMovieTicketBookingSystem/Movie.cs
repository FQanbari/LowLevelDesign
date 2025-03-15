namespace OnlineMovieTicketBookingSystem;

public enum Language
{
    HINDI,
    ENGLISH
}
public enum Genre
{
    ACTION,
    ROMANCE,
    COMEDY,
    HORROR
}

public class Movie
{
    public string Name { get; }
    public Language Language { get; }
    public Genre Genre { get; }

    public Movie(string name, Language language, Genre genre)
    {
        Name = name;
        Language = language;
        Genre = genre;
    }
}