﻿using Microsoft.EntityFrameworkCore;
using PlaylistCrud.Models;

namespace PlaylistCrud.Controllers.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) :base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().ToTable("Employee","HR");
        }
        public DbSet<Department> Departments{ get; set; }
        public DbSet<Employee> Employees{ get; set; }
    }
}
