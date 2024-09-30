using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using NurseNotes.Model;

namespace NurseNotes.Context
{
    public class TestDbNurseNotes : DbContext
    {
        public TestDbNurseNotes(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<UsersLogs> UsersLogs { get; set; }
        public DbSet<Patients> Patients { get; set; }
        public DbSet<NurseNote> NurseNotes { get; set; }
        public DbSet<PatientRecords> PatientRecords { get; set; }
        //public DbSet<UserTIpe> UsersTIpe { get; set; }

        /*Funcion para definir las relaciones entre dos tablas*/


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //USERS
                modelBuilder.Entity<Users>(entity => 
                { 
                    entity.HasKey(u => u.USR_ID);
         
                    entity.Property(u => u.FCHCREATION)
                      .HasDefaultValueSql("GETDATE()") 
                      .ValueGeneratedOnAdd();
                });
         
            //USERLOGS
                modelBuilder.Entity<UsersLogs>(entity =>
                {
                    entity.HasKey(log  => log.LOG_ID);
         
                    entity.Property(u => u.FCHMOD)
                      .HasDefaultValueSql("GETDATE()")
                      .ValueGeneratedOnAdd();
         
                });
            //PATIENTS
            modelBuilder.Entity<Patients>(entity =>
                {
                    entity.HasKey(pat => pat.PATIENT_ID);
                });
         
            //NURSENOTES
            modelBuilder.Entity<NurseNote>(entity =>
            {
                entity.HasKey(nn => nn.NOTE_ID);
            });
         
         
         
            //PATIENTRECORDS
            modelBuilder.Entity<PatientRecords>(entity =>
            {
                entity.HasKey(pr => pr.PATR_ID);
            });

            //FOLIOS
            modelBuilder.Entity<Folios>(entity =>
            {
                entity.HasKey(fl => fl.FOLIO_ID);
            });





            //INCOMES
            modelBuilder.Entity<Incomes>(entity =>
            {
                entity.HasKey(inc => inc.INCOME_ID);
            });
        }

    }
}
