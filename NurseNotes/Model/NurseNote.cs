namespace NurseNotes.Model
{
    public class NurseNote
    {
        public int NOTE_ID { get; set; }
        //public required Incomes Incomes { get; set; }
        public required Patients Patients { get; set; }
        public required string REASONCONS { get; set; }
        //public required Diagnosis Diagnosis { get; set; }
        //public required Specialities Specialities { get; set; }
        public required Users Users { get; set; }
        //public required Staff Staff { get; set; }

    }
}
