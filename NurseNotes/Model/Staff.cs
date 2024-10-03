namespace NurseNotes.Model
{
    public class Staff
    {
        public int STAFF_ID { get; set; }
        public required string MEDSTAFF { get; set; }
        public required Specialities Specialities { get; set; }
        public required Headquearters Headquearters { get; set; }
        public required Users Users { get; set; }  
    }
}
