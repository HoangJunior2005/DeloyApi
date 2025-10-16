using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("License")]
    public class License
    {
        [Key]
        [Column("license_id")]
        public int LicenseId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("license_number")]
        public string LicenseNumber { get; set; } = string.Empty;

        [Required]
        [Column("expiry_date", TypeName = "date")]
        public DateTime ExpiryDate { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("license_type_id")]
        public string LicenseTypeId { get; set; } = string.Empty;

        [MaxLength(255)]
        [Column("license_image_url")]
        public string? LicenseImageUrl { get; set; }

        // Navigation properties
        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;

        [ForeignKey("LicenseTypeId")]
        public virtual LicenseType LicenseType { get; set; } = null!;
    }
}


