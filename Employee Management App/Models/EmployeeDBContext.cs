using System;
using System.Data.Entity;

namespace Employee_Management_App.Models
{
    public class EmployeeDBContext : DbContext
    {
        public DbSet<Home> Employee_Table { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Home>().ToTable("Employee_Table");

            base.OnModelCreating(modelBuilder);
        }
    }
}
