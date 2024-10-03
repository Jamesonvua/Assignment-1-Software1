using System.ComponentModel.DataAnnotations;

namespace Assignment1EnterpriseSoftware.Models
{
    public class Request
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; } // Make nullable

        [Required]
        [EmailAddress]
        public string? Email { get; set; } // Make nullable

        [Required]
        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$", ErrorMessage = "Phone number must be in the format xxx-xxx-xxxx.")]
        public string? Phone { get; set; } // Make nullable

        [Required]
        public string? Role { get; set; } // Make nullable

        [Required]
        public EquipmentType EquipmentType { get; set; } // Enum type, should remain non-nullable

        [Required]
        public string? RequestDetails { get; set; } // Make nullable

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Duration must be greater than 0.")]
        public int Duration { get; set; } // Non-nullable, as int cannot be null
    }
}
