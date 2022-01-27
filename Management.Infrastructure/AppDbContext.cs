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
        public DbSet<Worker> Workers{ get; set; }
        public DbSet<Shift> Shifts{ get; set; }
        public DbSet<WorkerShift>  WorkerShifts { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
