using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class Medications
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MED_ID { get; set; }
        public required string MEDDSC {  get; set; }
        public required int STOCK {  get; set; }
    }
}
