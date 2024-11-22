

using System.ComponentModel.DataAnnotations;

namespace Dulces_Momentos.DTOs;
public class RoleDTO
{
    [MaxLength(250, ErrorMessage = "The name cannot exceed 50 characters")]
    [Required(ErrorMessage = "The name is required")]
    public string Name { get; set; }

    [MaxLength(255, ErrorMessage = "The description cannot exceed 255 characters")]
    [Required(ErrorMessage = "The name is required")]
    public string Description { get; set; }

}
