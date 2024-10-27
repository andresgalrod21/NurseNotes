using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    
    public class Scores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SCORE_ID { get; set; }
        public required String PLAYERNAME { get; set; }
        public required int AGE {  get; set; }
        public required String GENDER { get; set; }
        public required int SCORE {  get; set; }

    }
}
