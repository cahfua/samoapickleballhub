using System.ComponentModel.DataAnnotations;

namespace samoapickleballhub.Models;

public class Tournament
{
    public int Id { get; set; }

    [Required, StringLength(100)]
    public string Name { get; set; } = "";

    [Required]
    public DateTime EventDate { get; set; } = DateTime.Today;

    [Required, StringLength(100)]
    public string Location { get; set; } = "";

    [StringLength(500)]
    public string Description { get; set; } = "";

    [Range(2, 200)]
    public int MaxPlayers { get; set; } = 16;

    public string ImageUrl { get; set; } = "/images/tournament-placeholder.svg";
}