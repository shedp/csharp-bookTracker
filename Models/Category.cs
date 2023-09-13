using System.ComponentModel.DataAnnotations;

namespace csharp_intro.Models;

public class Category
{
    // type prop and tab key twice to get a shortcut
    // add a decorator to define the key
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    public int DisplayOrder { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    // we could have done this using a sql script
}