using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{

    public class Patients
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PATIENT_ID { get; set; }
        public required string NAME { get; set; }
        public required string LASTNAME { get; set; }
        public required int TIPDOC_ID { get; set; }
        public required int NUMDOC {  get; set; }
        public required int AGE { get; set; }
        public required int NUMCONTACT { get; set; }
        public required string? MAIL { get; set; }

        [ForeignKey("TIPDOC_ID")]
        public required TipDocs TipDocs { get; set; }

    }
}
