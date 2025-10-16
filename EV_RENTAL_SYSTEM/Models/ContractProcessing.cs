using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("ContractProcessing")]
    public class ContractProcessing
    {
        [Key]
        [Column("contract_processing_id")]
        public int ContractProcessingId { get; set; }

        [Column("contract_id")]
        public int ContractId { get; set; }

        [Column("step_id")]
        public int StepId { get; set; }

        [MaxLength(50)]
        public string? Status { get; set; }

        // Navigation properties
        [ForeignKey("ContractId")]
        public virtual Contract Contract { get; set; } = null!;

        [ForeignKey("StepId")]
        public virtual ProcessStep ProcessStep { get; set; } = null!;
    }
}


