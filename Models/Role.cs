

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dulces_Momentos.Models;

[Table("roles")]
public class Role
{
    [Key]
    [Column("id")]
    public int Id { get; set; }
    [Column("name")]
    [MaxLength(250, ErrorMessage = "The name cannot exceed 50 characters")]
    [Required(ErrorMessage = "The name is required")]
    public string Name { get; set; }
    [Column("description")]
    [MaxLength(255, ErrorMessage = "The description cannot exceed 255 characters")]
    [Required(ErrorMessage = "The name is required")]
    public string Description { get; set; }


    public Role()
    {
        
    }

    public Role(string name, string description)
    {
        Name = name;
        Description = description;
    }
}
