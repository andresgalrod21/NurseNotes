using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class Staff
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int STAFF_ID { get; set; }
        public required string MEDSTAFF { get; set; }
        public required int SPEC_ID { get; set; }
        public required int HEADQ_ID { get; set; }
        public required int USR_ID { get; set; }

        [ForeignKey("SPEC_ID")]
        public required virtual Specialities Specialities { get; set; }
        [ForeignKey("HEADQ_ID")]
        public required virtual Headquearters Headquearters { get; set; }
        [ForeignKey("USR_ID")]
        public required virtual Users Users { get; set; }  
    }
}
