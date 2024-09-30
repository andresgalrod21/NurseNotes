namespace NurseNotes.Model
{
    public class PatientRecords
    {
        public int PATR_ID { get; set; }    
        public required string RH {  get; set; }
        public required bool? ALLERGIES { get; set; }
        public required string? ALLERG_DSC {  get; set; }
        public required bool? SURGERIES { get; set; }
        public required string? SURGER_DSC { get; set; }
        public required Incomes Incomes { get; set; }
    }
}
