using System;
using System.ComponentModel.DataAnnotations;

namespace SR2.Models
{
    public class VehicleType
    {
        [Key]
        public Guid VehicleTypeId { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
