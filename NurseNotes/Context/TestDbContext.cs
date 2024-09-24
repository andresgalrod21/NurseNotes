using Microsoft.EntityFrameworkCore;
using NurseNotes.Model;
using static NurseNotes.Model.IUserRepository;

namespace NurseNotes.Context
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserTIpe> UsersTIpe { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);

        }
    }
}
