using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class Folios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FOLIO_ID { get; set; }
        public required int INCOME_ID { get; set; }
        public required int NOTE_ID { get; set; }
        public required int SUP_ID { get; set; }
        public required int USR_ID { get; set; }
        public required string? EVOLUTION { get; set; }

        [ForeignKey("INCOME_ID")]
        public required virtual Incomes Incomes { get; set; }
        [ForeignKey("NOTE_ID")]
        public required virtual NurseNote NurseNote { get; set; }
        [ForeignKey("SUP_ID")]
        public required virtual SuppliesPatients SuppliesPatients { get; set; }
        [ForeignKey("USR_ID")]
        public required virtual Users Users { get; set; }
    }
}
