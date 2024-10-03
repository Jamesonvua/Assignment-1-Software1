using System.ComponentModel.DataAnnotations;

namespace Assignment1EnterpriseSoftware.Models
{
    public enum EquipmentType
    {
        Laptop,
        Tablet,
        Phone,
        Another
    }

    public class Equipment
    {
        public int Id { get; set; }

        [Required]
        public EquipmentType EquipmentType { get; set; }  // Enum type

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public bool IsAvailable { get; set; }
    }
}
