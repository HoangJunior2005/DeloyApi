using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EV_RENTAL_SYSTEM.Models
{
    [Table("ProcessStep")]
    public class ProcessStep
    {
        [Key]
        [Column("step_id")]
        public int StepId { get; set; }

        [MaxLength(50)]
        [Column("step_name")]
        public string? StepName { get; set; }

        [MaxLength(255)]
        public string? Terms { get; set; }

        // Navigation properties
        public virtual ICollection<ContractProcessing> ContractProcessings { get; set; } = new List<ContractProcessing>();
    }
}


