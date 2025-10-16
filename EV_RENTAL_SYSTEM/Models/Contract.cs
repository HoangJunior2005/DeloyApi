using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("Contract")]
    public class Contract
    {
        [Key]
        [Column("contract_id")]
        public int ContractId { get; set; }

        [Column("order_id")]
        public int OrderId { get; set; }

        [MaxLength(50)]
        [Column("contract_code")]
        public string? ContractCode { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [NotMapped]
        public string? Status { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? Deposit { get; set; }

        [Column("rental_fee", TypeName = "decimal(10,2)")]
        public decimal? RentalFee { get; set; }

        [Column("extra_fee", TypeName = "decimal(10,2)")]
        public decimal? ExtraFee { get; set; }

        // Navigation properties
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; } = null!;

        public virtual ICollection<ContractProcessing> ContractProcessings { get; set; } = new List<ContractProcessing>();
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}


