// Data/ApplicationDbContext.cs
using Microsoft.EntityFrameworkCore;
using WorkOrderSystem.Entities;

public class WODbContext : DbContext
{
    public WODbContext(DbContextOptions<WODbContext> options)
        : base(options) { }

    public DbSet<WorkOrder> WorkOrders { get; set; }
    public DbSet<Technician> Technicians { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure the relationship between Technician and WorkOrder
        modelBuilder
            .Entity<WorkOrder>()
            .HasOne(w => w.Technician)
            .WithMany(t => t.WorkOrders)
            .HasForeignKey(w => w.TechnicianId);
    }
}
