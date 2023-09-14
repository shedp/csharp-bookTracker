using System.ComponentModel.DataAnnotations;

namespace csharp_intro.Models;

public class Book
{
    // type prop and tab key twice to get a shortcut
    // add a decorator to define the key
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public string Status { get; set; }
    public int Rating { get; set; }
    public int BookFormat { get; set; }
    // we could have done this using a sql script
}