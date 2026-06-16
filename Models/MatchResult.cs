using System.ComponentModel.DataAnnotations;

namespace samoapickleballhub.Models;

public class MatchResult
{
    public int Id { get; set; }

    [Required]
    public string PlayerOne { get; set; } = "";

    [Required]
    public string PlayerTwo { get; set; } = "";

    [Required]
    public string Winner { get; set; } = "";

    [Required]
    public string Score { get; set; } = "";

    public DateTime MatchDate { get; set; } = DateTime.Today;
}