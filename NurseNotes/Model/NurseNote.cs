using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class NurseNote
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NOTE_ID { get; set; }
        public required int INCOME_ID { get; set; }
        public required int PATIENT_ID { get; set; }
        public required string REASONCONS { get; set; }
        public required int DIAG_ID { get; set; }
        public required int SPEC_ID { get; set; }
        public required int USR_ID { get; set; }
        public required int STAFF_ID { get; set; }

        [ForeignKey("INCOME_ID")]
        public required virtual Incomes Incomes { get; set; }
        [ForeignKey("PATIENT_ID")]
        public required virtual Patients Patients { get; set; }
        [ForeignKey("DIAG_ID")]
        public required virtual Diagnosis Diagnosis { get; set; }
        [ForeignKey("SPEC_ID")]
        public required virtual Specialities Specialities { get; set; }
        [ForeignKey("USR_ID")]
        public required virtual Users Users { get; set; }
        [ForeignKey("STAFF_ID")]
        public required virtual Staff Staff { get; set; }


    }
}
