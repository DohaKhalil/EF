using EntityFrameworkAssignment.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkAssignment.DataContext
{
    internal class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-T3NIN6L\\MSSQLSERVER01;Database=EntityFrameworkAssignment;Trusted_Connection=True;TrustServerCertificate=true", sqlServerOptionsAction: x => x.UseDateOnlyTimeOnly());

        }

        public DbSet<AirCraft> AirCraft { get; set; }
        public DbSet<AirCraft_Route> AirCraft_Routes { get; set; }
        public DbSet<AirLine> AirLines { get; set; }
        public DbSet<AirLine_Phone> AirLine_Phones { get; set; }
        public DbSet<Emp_Cualification> Emp_Cualifications { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
           .HasOne(transaction => transaction.AirLines)
           .WithMany(airline => airline.Transaction)
           .HasForeignKey(airline => airline.AirLineId);


            //modelBuilder.Entity<Employee>()
            //.HasOne(a => a.AirLine) 
            //.WithMany(e => e.Employees)     
            //.HasForeignKey(e => new { e.AirLineId}).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Employee>().HasKey(e => e.Id);
            modelBuilder.Entity<AirLine>()
           .HasKey(a => a.Id);
            modelBuilder.Entity<AirLine>()
           .HasMany(a => a.Employees)
           .WithOne(e => e.AirLine)
           .HasForeignKey(e => e.AirLineId).OnDelete(DeleteBehavior.Restrict).IsRequired(false);
 

            modelBuilder.Entity<AirLine_Phone>().HasKey(K => new { K.phone, K.AirLineId });
            modelBuilder.Entity<AirLine_Phone>().HasOne(A => A.AirLinesPh).WithMany(Ph => Ph.AirLine_Phones).HasForeignKey(FK => FK.AirLineId);

            modelBuilder.Entity<AirCraft>().HasKey(e => e.Id);  
            modelBuilder.Entity<AirCraft>()
           .HasOne(A => A.AirLine)
           .WithMany(AC => AC.AirCrafts)
           .HasForeignKey(AirC => AirC.AirLineId);

            modelBuilder.Entity<Emp_Cualification>().HasKey(EC => new { EC.EmployeesId, EC.Qulification });
            modelBuilder.Entity<Emp_Cualification>()
           .HasOne(e => e.Employees)
           .WithMany(emp => emp.Emp_Cualification)
           .HasForeignKey(emp => emp.EmployeesId);


            modelBuilder.Entity<AirCraft_Route>().HasKey(KR => new { KR.ACRId, KR.RoutId });




        }

    }
}
