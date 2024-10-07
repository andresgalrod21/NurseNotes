using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace NurseNotes.Model
{
    public class SuppliesPatients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SUP_ID {  get; set; }
        public required int CANTSUP {  get; set; }
        public required int INCOME_ID { get; set; }
        public required int MED_ID { get; set; }
        [ForeignKey("INCOME_ID")]
        public required virtual Incomes Incomes { get; set; }
        [ForeignKey("MED_ID")]
        public required virtual Medications Medications { get; set; }
       
    }
}
