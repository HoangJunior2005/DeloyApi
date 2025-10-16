using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Column("order_id")]
        public int OrderId { get; set; }

        [Column("order_date")]
        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column("start_time")]
        public DateTime? StartTime { get; set; }

        [Column("end_time")]
        public DateTime? EndTime { get; set; }

        [Column("total_amount", TypeName = "decimal(10,2)")]
        public decimal? TotalAmount { get; set; }

        [MaxLength(50)]
        [Column("status")]
        public string? Status { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        // Navigation properties
        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;

        public virtual ICollection<Order_LicensePlate> OrderLicensePlates { get; set; } = new List<Order_LicensePlate>();
        public virtual ICollection<Complaint> Complaints { get; set; } = new List<Complaint>();
        public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
    }
}


