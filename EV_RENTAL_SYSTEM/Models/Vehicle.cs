using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using EV_RENTAL_SYSTEM.Models.Enums;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("Vehicle")]
    public class Vehicle
    {
        [Key]
        [Column("vehicle_id")]
        public int VehicleId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; } = string.Empty;

        [Column("model_year")]
        public int? ModelYear { get; set; }

        [Column("brand_id")]
        public int BrandId { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        [Column("price_per_day", TypeName = "decimal(10,2)")]
        public decimal? PricePerDay { get; set; }

        [Column("seat_number")]
        public int? SeatNumber { get; set; }

        [MaxLength(500)]
        [Column("vehicle_image")]
        public string? VehicleImage { get; set; }

        [Column("battery", TypeName = "decimal(5,2)")]
        public decimal? Battery { get; set; } // Dung lượng pin (kWh)

        [Column("range_km")]
        public int? RangeKm { get; set; } // Tầm hoạt động (km)

        // Navigation properties
        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; } = null!;

        public virtual ICollection<LicensePlate> LicensePlates { get; set; } = new List<LicensePlate>();
    }
}


