using System.ComponentModel.DataAnnotations;

namespace samoapickleballhub.Models;

public class Announcement
{
    public int Id { get; set; }

    [Required, StringLength(120)]
    public string Title { get; set; } = "";

    [Required, StringLength(800)]
    public string Content { get; set; } = "";

    public string Category { get; set; } = "Community";

    public DateTime PostedDate { get; set; } = DateTime.Today;
}