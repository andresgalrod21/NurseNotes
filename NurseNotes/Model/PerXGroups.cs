namespace NurseNotes.Model
{
    public class PerXGroups
    {
        public int PG_ID { get; set; }
        public required Groups Groups {  get; set; }
        public required Permitions Permitions { get; set; } 
    }
}
