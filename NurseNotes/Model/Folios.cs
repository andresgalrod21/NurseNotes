namespace NurseNotes.Model
{
    public class Folios
    {
        public int FOLIO_ID { get; set; }
        public required Incomes Incomes { get; set; }
        public required NurseNote NurseNote { get; set; }
        //public required SuppliesPatients SuppliesPatients { get; set; }
        public required Users Users { get; set; }
        public required string? EVOLUTION { get; set; }
    }
}
