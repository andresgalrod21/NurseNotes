namespace NurseNotes.Model
{
    public class Signs
    {
        public int SIGN_ID { get; set; }
        public required NurseNote NurseNote { get; set; }
        public required int TEMPERATURE { get; set; }
        public required string PULSE {  get; set; }
    }
}
