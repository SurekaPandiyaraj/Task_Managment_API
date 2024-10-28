using Microsoft.EntityFrameworkCore;
using Task_Managment.Models;

namespace Task_Managment.Database
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(o => o.Tasks)
                .WithOne(p => p.User)
                .HasForeignKey(o => o.AssingeId);


            modelBuilder.Entity<User>()
                .HasOne(a => a.Address)
                .WithOne(b => b.User)
                .HasForeignKey<Address>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

    }
}
