// Create an admin for CricLive
using LiveCricketCommentary;
using MatchType = LiveCricketCommentary.MatchType;

Admin admin = new Admin("adminUser", "adminPass123");
CricLive cricLive = new CricLive(admin);

// Create teams
Team teamIndia = new Team("India");
Team teamAustralia = new Team("Australia");

// Create players for India
Player virat = new Player("Virat Kohli", new DateTime(1988, 11, 5), teamIndia);
Player rohit = new Player("Rohit Sharma", new DateTime(1987, 4, 30), teamIndia);
Player bumrah = new Player("Jasprit Bumrah", new DateTime(1993, 12, 6), teamIndia);

// Create players for Australia
Player smith = new Player("Steve Smith", new DateTime(1989, 6, 2), teamAustralia);
Player warner = new Player("David Warner", new DateTime(1986, 10, 27), teamAustralia);
Player cummins = new Player("Pat Cummins", new DateTime(1993, 5, 8), teamAustralia);

// Add players to teams
teamIndia.AddPlayer(virat);
teamIndia.AddPlayer(rohit);
teamIndia.AddPlayer(bumrah);
teamAustralia.AddPlayer(smith);
teamAustralia.AddPlayer(warner);
teamAustralia.AddPlayer(cummins);

// Create tournament
Tournament worldCup = new Tournament("Cricket World Cup", "England", "2023");
cricLive.AddTournament(worldCup);

// Create playing elevens
PlayingEleven indiaXI = teamIndia.SelectTournamentSquad().SelectPlayingEleven();
PlayingEleven ausXI = teamAustralia.SelectTournamentSquad().SelectPlayingEleven();

// Create a match
Match match = new Match(indiaXI, ausXI, "Lord's", DateTime.Now, MatchType.Odi);

// Simulate first inning
Inning firstInning = new Inning(1);
Over firstOver = new Over(1);

// Create a ball
Ball ball1 = new Ball(cummins, virat);
ball1.Type = DeliveryType.Normal;
Run run = new Run { TotalRuns = 4, Boundary = true };
ball1.Run = run;
ball1.Commentary = new Commentary("What a beautiful cover drive by Kohli!");

// Add ball to over
firstOver.AddBall(ball1);

// Simulate a wicket
Ball ball2 = new Ball(cummins, virat);
ball2.Type = DeliveryType.Normal;
ball2.Wicket = new Wicket
{
    WicketType = WicketType.Bowled,
    Batsman = virat,
    By = cummins
};
ball2.Commentary = new Commentary("Clean bowled! Cummins gets Kohli!");
firstOver.AddBall(ball2);

// Add over to inning
firstInning.AddOver(firstOver);
match.Innings.Add(firstInning);

// Add match to tournament
worldCup.AddMatch(match);

// Add commentator
Commentator commentator = new Commentator("Ian Bishop");
commentator.Commentary = new Commentary("What an exciting start to the match!");
cricLive.AddCommentator(commentator);

// Display some results
Console.WriteLine($"Match: {teamIndia.Name} vs {teamAustralia.Name}");
Console.WriteLine($"Venue: {match.Venue}");
Console.WriteLine($"First Inning Score: {firstInning.GetTotalScore()}/{firstOver.GetTotalWickets()}");
Console.WriteLine($"Commentary: {commentator.Commentary.Text}");
Console.WriteLine("\nFirst Over Details:");

foreach (var ball in firstOver.Balls)
{
    Console.WriteLine($"- {ball.Commentary.Text}");
}

// Update player records
virat.Record.TotalRuns += 4;
virat.Record.MatchesPlayed += 1;
cummins.Record.TotalWickets += 1;
cummins.Record.MatchesPlayed += 1;

Console.WriteLine($"\nPlayer Stats:");
Console.WriteLine($"{virat.Name} - Runs: {virat.Record.TotalRuns}");
Console.WriteLine($"{cummins.Name} - Wickets: {cummins.Record.TotalWickets}");