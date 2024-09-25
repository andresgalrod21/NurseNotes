using Microsoft.EntityFrameworkCore;
using NurseNotes.Model;

namespace NurseNotes.Context
{
    public class TestDbNurseNotes : DbContext
    {
        public TestDbNurseNotes(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<Users> Users { get; set; }
        //public DbSet<UserTIpe> UsersTIpe { get; set; }

        /*Funcion para definir las relaciones entre dos tablas*/


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Users>()
                .HasKey(u => u.USR_ID);

        }
    }
}
