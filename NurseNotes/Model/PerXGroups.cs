using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class PerXGroups
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PG_ID { get; set; }
        public required int GRP_ID { get; set; }
        public required int PER_ID { get; set; }
        [ForeignKey("GRP_ID")]
        public required virtual Groups Groups {  get; set; }
        [ForeignKey("PER_ID")]
        public required virtual Permitions Permitions { get; set; } 
    }
}
