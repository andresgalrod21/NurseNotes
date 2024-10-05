namespace NurseNotes.Model
{
    public class UsersLogs
    {
        public int LOG_ID { get; set; }

        public required Users Users { get; set; }

        public required DateTime FCHMOD { get; set; }
        public required String USRMOD { get; set; }
    }
}
