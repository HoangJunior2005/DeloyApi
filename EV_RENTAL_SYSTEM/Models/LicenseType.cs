using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("LicenseType")]
    public class LicenseType
    {
        [Key]
        [Column("license_type_id")]
        public string LicenseTypeId { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        [Column("type_name")]
        public string TypeName { get; set; } = string.Empty;

        [MaxLength(255)]
        public string? Description { get; set; }

        // Navigation properties
        public virtual ICollection<License> Licenses { get; set; } = new List<License>();
    }
}


