
using OnlineMovieTicketBookingSystem;

public class BookMyShow
{
    private readonly List<Theater> theaters;
    private static Dictionary<string, List<Show>> movieMap;

    public BookMyShow(List<Theater> theaters)
    {
        this.theaters = theaters;
        movieMap = new Dictionary<string, List<Show>>();
        GenerateMovieMap();
        
    }

    private void GenerateMovieMap()
    {
        foreach (var theater in theaters)
        {
            foreach (var show in theater.Shows)
            {
                if (!movieMap.ContainsKey(show.Movie.Name))
                    movieMap[show.Movie.Name] = new List<Show>();
                movieMap[show.Movie.Name].Add(show);
            }
        }
    }

    public List<Show> SearchShows(string movieName) =>
        movieMap.ContainsKey(movieName) ? movieMap[movieName] : null;
}
