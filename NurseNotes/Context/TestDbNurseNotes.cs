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
        public DbSet<TipDocs> TipDoc { get; set; }
        public DbSet<Patients> Patient { get; set; }
        public DbSet<NurseNote> NurseNotes { get; set; }
        public DbSet<PatientRecords> PatientRecords { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Folios> Folios { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Incomes> Incomes { get; set; }
        public DbSet<Medications> Medications { get; set; }
        public DbSet<Permitions> Permitions { get; set; }
        public DbSet<PerXGroups> PerXGroups { get; set; }
        public DbSet<Signs> Signs { get; set; }
        public DbSet<Specialities> Specialities { get; set; }
        public DbSet<Staff> Staffs { get; set; }

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

            //DIAGNOSIS
            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.HasKey(dg => dg.DIAG_ID);
            });

            //GROUPS
            modelBuilder.Entity<Groups>(entity =>
            {
                entity.HasKey(gr => gr.GRP_ID);
            });

            //HEADQ
            modelBuilder.Entity<Headquearters>(entity =>
            {
                entity.HasKey(hq => hq.HEADQ_ID);
            });

            //INCOMES
            modelBuilder.Entity<Incomes>(entity =>
            {
                entity.HasKey(inc => inc.INCOME_ID);

                entity.Property(incc => incc.FCHINCOME)
                      .HasDefaultValueSql("GETDATE()")
                      .ValueGeneratedOnAdd();
            });

            //MEDICATIONS
            modelBuilder.Entity<Medications>(entity =>
            {
                entity.HasKey(md => md.MED_ID);
            });

            //PERMITIONS
            modelBuilder.Entity<Permitions>(entity =>
            {
                entity.HasKey(per => per.PER_ID);
            });

            //PERXGROUP
            modelBuilder.Entity<PerXGroups>(entity =>
            {
                entity.HasKey(pg => pg.PG_ID);
            });

            //SIGNS
            modelBuilder.Entity<Signs>(entity =>
            {
                entity.HasKey(s => s.SIGN_ID);
            });

            //SPECIALITIES
            modelBuilder.Entity<Specialities>(entity =>
            {
                entity.HasKey(sp => sp.SPEC_ID);
            });

            //STAFF
            modelBuilder.Entity<Staff>(entity =>
            {
                entity.HasKey(st => st.STAFF_ID);
            });

            //SUPPLIESPATIENTS
            modelBuilder.Entity<SuppliesPatients>(entity =>
            {
                entity.HasKey(sup => sup.SUP_ID);
            });

            //TIPDOCS
            modelBuilder.Entity<TipDocs>(entity =>
            {
                entity.HasKey(tp => tp.TIPDOC_ID);
            });

        }

    }
}
