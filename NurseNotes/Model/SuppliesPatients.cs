namespace NurseNotes.Model
{
    public class SuppliesPatients
    {
        public int SUP_ID {  get; set; }
        public required int CANTSUP {  get; set; }
        public required Incomes Incomes { get; set; }
        public required Medications Medications { get; set; }
       
    }
}
