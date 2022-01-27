using Management.Domain.Shifts;
using Management.Domain.Workers;
using Management.Domain.WorkerShifts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Management.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<WorkerShift> WorkerShifts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shift>().HasData(
                new Shift { Id = 1, StartTime = DateTime.Parse("2009-06-15T00:00:00"), EndTime = DateTime.Parse("2009-06-15T08:00:00") },
                new Shift { Id = 2, StartTime = DateTime.Parse("2009-06-15T08:00:00"), EndTime = DateTime.Parse("2009-06-15T16:00:00") },
                new Shift { Id = 3, StartTime = DateTime.Parse("2009-06-15T16:00:00"), EndTime = DateTime.Parse("2009-06-15T23:59:59") });
        }
    }
}
