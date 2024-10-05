namespace NurseNotes.Model
{
    public class Patients
    {
        public int PATIENT_ID { get; set; }
        public required string NAME { get; set; }
        public required string LASTNAME { get; set; }
        public required TipDocs TipDocs { get; set; }
        public required int NUMDOC {  get; set; }
        public required int AGE { get; set; }
        public required int NUMCONTACT { get; set; }
        public required string? MAIL { get; set; }
    }
}
