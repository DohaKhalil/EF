using EFSossion2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSossion2.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-T3NIN6L\\SQLEXPRESS;Database=EFssession2;Trusted_Connection=True;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasOne<Department>().WithOne(M => M.Manager).HasForeignKey<Department>(d=> d.EmpId);
            modelBuilder.Entity<Employee>().HasOne<Department>().WithMany(c => c.Employee);


        }

    }

}
