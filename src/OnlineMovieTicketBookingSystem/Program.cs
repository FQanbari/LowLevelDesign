/* --------Data generation code ----START ----------------- */

// Creating Guest User --> Piyush
using OnlineMovieTicketBookingSystem;

GuestUser piyush = new GuestUser("Piyush");

// Creating Registered User --> Ayush
RegisteredUser ayush = new RegisteredUser("Ayush");

// Creating Registered User --> Saurabh
RegisteredUser saurabh = new RegisteredUser("Saurabh");

// Creating Movie object --> Iron Man
Movie ironMan = new Movie("Iron Man", Language.ENGLISH, Genre.ACTION);

// Creating Movie object --> Avengers: End Game
Movie avengers = new Movie("Avengers: End Game", Language.ENGLISH, Genre.ACTION);

// Creating Movie object --> The Walk To Remember
Movie walkToRemember = new Movie("The Walk To Remember", Language.ENGLISH, Genre.ROMANCE);

// Creating Movie object --> HouseFull2
Movie housefull = new Movie("HouseFull 2", Language.HINDI, Genre.COMEDY);

// Creating Theater --> PVR @ GIP Noida with capacity 30
Theater pvr_gip = new Theater("PVR", 30);

// Creating Another Theater --> BIG Cinema @ Noida Sector 137 with capacity 40
Theater big_cinema = new Theater("Big Cinema", 40);

// Creating four shows for movies
Show show1 = null, show2 = null, show3 = null, show4 = null;

try
{
    string format = "dddd, MMM d, yyyy hh:mm:ss tt";

    // استفاده از "Sunday" به جای "Friday" چون 7 ژوئن 2020 یکشنبه بود
    DateTime date1 = DateTime.ParseExact("Sunday, Jun 7, 2020 09:00:00 AM", format, System.Globalization.CultureInfo.InvariantCulture);
    show1 = new Show(date1, ironMan, pvr_gip);

    DateTime date2 = DateTime.ParseExact("Sunday, Jun 7, 2020 12:00:00 PM", format, System.Globalization.CultureInfo.InvariantCulture);
    show2 = new Show(date2, housefull, pvr_gip);

    DateTime date3 = DateTime.ParseExact("Sunday, Jun 7, 2020 09:00:00 AM", format, System.Globalization.CultureInfo.InvariantCulture);
    show3 = new Show(date3, walkToRemember, big_cinema);

    DateTime date4 = DateTime.ParseExact("Sunday, Jun 7, 2020 12:00:00 PM", format, System.Globalization.CultureInfo.InvariantCulture);
    show4 = new Show(date4, walkToRemember, big_cinema);
}
catch (Exception e)
{
    Console.WriteLine($"Error parsing date: {e.Message}");
}

/* --------Data generation code ---- END ----------------- */

// Now we have two theaters with their shows, let's add these theaters to our Book My Show app
List<Theater> theaterArrayList = new List<Theater> { pvr_gip, big_cinema };
BookMyShow bookMyShow = new BookMyShow(theaterArrayList);

// Searching Book My Show for all the shows of movie WALK TO REMEMBER
List<Show> searchedShow = bookMyShow.SearchShows("The Walk To Remember");

if (searchedShow != null && searchedShow.Count > 0)
{
    // Now suppose AYUSH and SAURABH both want to book 10 tickets each for the first show
    Show bookingShow = searchedShow[0];

    // Ticket Booking Tasks for AYUSH and SAURABH
    Task<Ticket> t1 = Task.Run(() => bookingShow.BookTicket(ayush, 10));
    Task<Ticket> t2 = Task.Run(() => bookingShow.BookTicket(saurabh, 10));

    // Waiting for both tasks to complete
    await Task.WhenAll(t1, t2);

    // After execution, get the tickets
    Ticket ayushTicket = t1.Result;
    Ticket saurabhTicket = t2.Result;

    // Printing their tickets
    Console.WriteLine(ayushTicket?.ToString() ?? "Ayush ticket booking failed");
    Console.WriteLine(saurabhTicket?.ToString() ?? "Saurabh ticket booking failed");

    // Now, 20 seats are booked for this show and 20 seats are available
    // Suppose AYUSH wants another 15 seats and SAURABH wants another 10 seats
    Task<Ticket> t3 = Task.Run(() => bookingShow.BookTicket(ayush, 15));
    Task<Ticket> t4 = Task.Run(() => bookingShow.BookTicket(saurabh, 10));

    // Waiting for both tasks to complete
    await Task.WhenAll(t3, t4);

    // After execution, get the new tickets
    Ticket ayushNewTicket = t3.Result;
    Ticket saurabhNewTicket = t4.Result;

    // Printing their new tickets
    Console.WriteLine(ayushNewTicket?.ToString() ?? "Ayush new ticket booking failed");
    Console.WriteLine(saurabhNewTicket?.ToString() ?? "Saurabh new ticket booking failed");

    /* Running this program several times, we will notice that 
    if t3 completes the bookTicket function first, 
    then ticket is allocated to Ayush, 
    otherwise ticket is allocated to Saurabh.
    */
}
else
{
    Console.WriteLine("No shows found for 'The Walk To Remember'");
}