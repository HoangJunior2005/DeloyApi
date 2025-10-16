using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("Complaint")]
    public class Complaint
    {
        [Key]
        [Column("complaint_id")]
        public int ComplaintId { get; set; }

        [Column("complaint_date")]
        public DateTime ComplaintDate { get; set; } = DateTime.Now;

        [MaxLength(255)]
        public string? Description { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        // Navigation properties
        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; } = null!;
    }
}


