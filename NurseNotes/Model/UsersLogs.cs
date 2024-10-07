using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class UsersLogs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LOG_ID { get; set; }
        public required int USR_ID { get; set; }
        public required DateTime FCHMOD { get; set; }
        public required String USRMOD { get; set; }

        [ForeignKey("USR_ID")]
        public required virtual Users Users { get; set; }

    }
}
