using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class Incomes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int INCOME_ID {  get; set; }
        public required int TIPDOC_ID { get; set; }
        public required int PATIENT_ID { get; set; }
        public required DateTime FCHINCOME {  get; set; }
        public required int USR_ID { get; set; }

        [ForeignKey("TIPDOC_ID")]
        public required virtual TipDocs TipDocs { get; set; }
        [ForeignKey("PATIENT_ID")]
        public required virtual Patients Patients { get; set; }
        [ForeignKey("USR_ID")]
        public required virtual Users Users { get; set; }
    }
}
