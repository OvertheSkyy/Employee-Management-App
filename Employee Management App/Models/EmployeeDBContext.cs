using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Employee_Management_App.Models
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Home> Employee_Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Home>()
                .ToTable("Employee_Table")
                .HasKey(e => e.Id)
                .Property(e => e.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
