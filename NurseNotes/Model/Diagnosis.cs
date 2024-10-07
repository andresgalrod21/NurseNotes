using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class Diagnosis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DIAG_ID { get; set; }
        public required string DIAGDSC {  get; set; }
    }
}
