using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [Key]
        [Column("transaction_id")]
        public int TransactionId { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Amount { get; set; }

        [Column("transaction_date")]
        public DateTime TransactionDate { get; set; } = DateTime.Now;

        [Column("payment_id")]
        public int PaymentId { get; set; }

        [Column("user_id")]
        public int UserId { get; set; }

        // Navigation properties
        [ForeignKey("PaymentId")]
        public virtual Payment Payment { get; set; } = null!;

        [ForeignKey("UserId")]
        public virtual User User { get; set; } = null!;
    }
}


