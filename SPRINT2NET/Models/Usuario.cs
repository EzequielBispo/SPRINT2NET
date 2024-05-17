using System.ComponentModel.DataAnnotations;

namespace SPRINT2NET.Models
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    // Outras propriedades...
}
}
