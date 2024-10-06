using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{

        public class Users
        {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int USR_ID { get; set; }
            public required string NAME { get; set; }
            public required string LASTNAME { get; set; }
            public required string TIPDOC { get; set; }
            public required int NUMDOC { get; set; }
            public required string USRPSW { get; set; }
            public required string USR { get; set; }
            public required DateTime FCHCREATION { get; set; }
            public required int GRP_ID { get; set; }

        [ForeignKey("GRP_ID")]    
        public required virtual Groups Group { get; set; }

    }
    
}
