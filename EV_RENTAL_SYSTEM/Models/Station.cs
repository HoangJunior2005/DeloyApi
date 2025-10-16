using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("Station")]
    public class Station
    {
        [Key]
        [Column("station_id")]
        public int StationId { get; set; }

        [MaxLength(100)]
        [Column("station_name")]
        public string? StationName { get; set; }

        [MaxLength(100)]
        public string? Street { get; set; }

        [MaxLength(50)]
        public string? District { get; set; }

        [MaxLength(50)]
        public string? Province { get; set; }

        [MaxLength(50)]
        public string? Country { get; set; }

        [Column("total_vehicle")]
        public int TotalVehicle { get; set; }

        [Column("available_vehicle")]
        public int AvailableVehicle { get; set; }

        // Navigation properties
        public virtual ICollection<LicensePlate> LicensePlates { get; set; } = new List<LicensePlate>();
        public virtual ICollection<User> Staff { get; set; } = new List<User>(); // Staff quản lý trạm này
    }
}


