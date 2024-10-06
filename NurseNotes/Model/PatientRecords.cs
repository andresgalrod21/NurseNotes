using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class PatientRecords
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PATR_ID { get; set; }    
        public required string RH {  get; set; }
        public required bool? ALLERGIES { get; set; }
        public required string? ALLERG_DSC {  get; set; }
        public required bool? SURGERIES { get; set; }
        public required string? SURGER_DSC { get; set; }
        public required int INCOME_ID { get; set; }
        [ForeignKey("INCOME_ID")]
        public required virtual Incomes Incomes { get; set; }
    }
}
