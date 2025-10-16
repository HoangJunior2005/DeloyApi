using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EV_RENTAL_SYSTEM.Models.Enums;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("LicensePlate")]
    public class LicensePlate
    {
        [Key]
        [Column("license_plate_id")]
        public int LicensePlateId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("plate_number")]
        public string PlateNumber { get; set; } = string.Empty;

        [MaxLength(50)]
        public string? Status { get; set; } // Trạng thái biển số (Available, Rented, Maintenance)

        [Column("vehicle_id")]
        public int VehicleId { get; set; }

        [Column("registration_date", TypeName = "date")]
        public DateTime? RegistrationDate { get; set; }

        [Column("station_id")]
        public int StationId { get; set; }

        // Navigation properties
        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle { get; set; } = null!;

        [ForeignKey("StationId")]
        public virtual Station Station { get; set; } = null!;

        public virtual ICollection<Order_LicensePlate> OrderLicensePlates { get; set; } = new List<Order_LicensePlate>();
        public virtual ICollection<Maintenance> Maintenances { get; set; } = new List<Maintenance>();
    }
}


