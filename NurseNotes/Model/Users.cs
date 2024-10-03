namespace NurseNotes.Model
{

        public class Users
        {
            public int USR_ID { get; set; }
            public required string NAME { get; set; }
            public required string LASTNAME { get; set; }
            public required string TIPDOC { get; set; }
            public required int NUMDOC { get; set; }
            public required string USRPSW { get; set; }
            public required string USR { get; set; }
            public required DateTime FCHCREATION { get; set; }
            public required Groups Groups { get; set; }
    }
    
}
