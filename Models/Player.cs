using System.ComponentModel.DataAnnotations;

namespace samoapickleballhub.Models;

public class Player
{
    public int Id { get; set; }

    [Required, StringLength(80)]
    public string Name { get; set; } = "";

    [Required, EmailAddress]
    public string Email { get; set; } = "";

    [StringLength(30)]
    public string Phone { get; set; } = "";

    [Required]
    public string SkillLevel { get; set; } = "Beginner";

    [Required]
    public string Village { get; set; } = "";

    public string ImageUrl { get; set; } = "/images/player-placeholder.svg";

    public int Wins { get; set; }

    public int Losses { get; set; }

    public double WinRate => Wins + Losses == 0 ? 0 : Math.Round((double)Wins / (Wins + Losses) * 100, 1);
}