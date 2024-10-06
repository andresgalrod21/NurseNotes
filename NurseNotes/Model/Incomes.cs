namespace NurseNotes.Model
{
    public class Incomes
    {
        public int INCOME_ID {  get; set; }
        public required TIPDOCS TIPDOCS {  get; set; }
        public required Patients Patients { get; set; }
        public required DateTime FCHINCOME {  get; set; }
        public required Users Users { get; set; }
    }
}
