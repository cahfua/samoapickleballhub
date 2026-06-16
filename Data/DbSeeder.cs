using Microsoft.EntityFrameworkCore;
using samoapickleballhub.Models;

namespace samoapickleballhub.Data;

public static class DbSeeder
{
    public static async Task SeedAsync(WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

        await db.Database.MigrateAsync();

        if (!db.Players.Any())
        {
            db.Players.AddRange(
                new Player { Name = "Tavita M.", Email = "tavita@example.com", Phone = "555-1001", SkillLevel = "Advanced", Village = "Apia", Wins = 8, Losses = 2 },
                new Player { Name = "Malia S.", Email = "malia@example.com", Phone = "555-1002", SkillLevel = "Intermediate", Village = "Vaitele", Wins = 6, Losses = 3 },
                new Player { Name = "Sione A.", Email = "sione@example.com", Phone = "555-1003", SkillLevel = "Beginner", Village = "Faleula", Wins = 3, Losses = 4 },
                new Player { Name = "Lina T.", Email = "lina@example.com", Phone = "555-1004", SkillLevel = "Advanced", Village = "Lotopa", Wins = 9, Losses = 1 }
            );
        }

        if (!db.Tournaments.Any())
        {
            db.Tournaments.AddRange(
                new Tournament { Name = "Apia Summer Smash", EventDate = DateTime.Today.AddDays(10), Location = "Apia Sports Complex", Description = "Community doubles tournament for all levels.", MaxPlayers = 32 },
                new Tournament { Name = "Samoa Pickleball Open", EventDate = DateTime.Today.AddDays(25), Location = "Vaitele Courts", Description = "Competitive tournament with beginner and advanced divisions.", MaxPlayers = 48 },
                new Tournament { Name = "Family Fun Pickleball Day", EventDate = DateTime.Today.AddDays(40), Location = "Faleata", Description = "Family-friendly pickleball event for the community.", MaxPlayers = 24 }
            );
        }

        if (!db.MatchResults.Any())
        {
            db.MatchResults.AddRange(
                new MatchResult { PlayerOne = "Tavita M.", PlayerTwo = "Malia S.", Winner = "Tavita M.", Score = "11-7", MatchDate = DateTime.Today.AddDays(-3) },
                new MatchResult { PlayerOne = "Lina T.", PlayerTwo = "Sione A.", Winner = "Lina T.", Score = "11-4", MatchDate = DateTime.Today.AddDays(-2) },
                new MatchResult { PlayerOne = "Malia S.", PlayerTwo = "Sione A.", Winner = "Malia S.", Score = "11-8", MatchDate = DateTime.Today.AddDays(-1) }
            );
        }

        if (!db.Announcements.Any())
        {
            db.Announcements.AddRange(
                new Announcement { Title = "New player registration is open", Content = "Players can now register and be added to the community player list.", Category = "Community", PostedDate = DateTime.Today.AddDays(-5) },
                new Announcement { Title = "Upcoming tournament schedule posted", Content = "Tournament dates and locations have been added for upcoming Samoa pickleball events.", Category = "Tournament", PostedDate = DateTime.Today.AddDays(-2) },
                new Announcement { Title = "Leaderboard updates weekly", Content = "Match results will be used to help track wins, losses, and player rankings.", Category = "Leaderboard", PostedDate = DateTime.Today }
            );
        }

        await db.SaveChangesAsync();
    }
}