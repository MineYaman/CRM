using CRM.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.DataAccess.Concrete.EfCore
{
    public class CrmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CrmDb;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserRole>()
                    .HasKey(c => new { c.UserId, c.RoleId });

            modelBuilder.Entity<Assignment>()
                    .HasKey(c => new {  c.DepartmentId, c.UserId, c.JobId });

            modelBuilder.Entity<DepartmentJob>()
                    .HasKey(c => new { c.DepartmentId, c.JobId });

            modelBuilder.Entity<DepartmentStaff>()
                    .HasKey(c => new { c.DepartmentId, c.UserId });

            modelBuilder.Entity<JobState>()
                    .HasKey(c => new { c.JobId, c.StateId });

            modelBuilder.Entity<CustomerJob>()
                   .HasKey(c => new { c.CustomerId, c.JobId });

            modelBuilder.Entity<DepartmentAttendant>()
                   .HasKey(c => new { c.UserId, c.DepartmentId });
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentAttendant> DepartmentAttendants { get; set; }
        public DbSet<DepartmentStaff> DepartmentStaffs { get; set; }
        public DbSet<DepartmentJob> DepartmentJobs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerJob> CustomerJobs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobState> JobStates { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}
