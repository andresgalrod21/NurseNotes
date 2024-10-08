﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NurseNotes.Model
{
    public class Signs
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SIGN_ID { get; set; }
        public required int NOTE_ID { get; set; }
        public required int TEMPERATURE { get; set; }
        public required string PULSE {  get; set; }

        [ForeignKey("NOTE_ID")]
        public required NurseNote NurseNote { get; set; }

    }
}
