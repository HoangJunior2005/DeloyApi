using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("Order_LicensePlate")]
    public class Order_LicensePlate
    {
        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("license_plate_id")]
        public int LicensePlateId { get; set; }

        // Navigation properties
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; } = null!;

        [ForeignKey("LicensePlateId")]
        public virtual LicensePlate LicensePlate { get; set; } = null!;
    }
}


