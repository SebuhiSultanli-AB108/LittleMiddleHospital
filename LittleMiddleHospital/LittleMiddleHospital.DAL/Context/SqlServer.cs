using LittleMiddleHospital.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace LittleMiddleHospital.DAL.Context;

public class SqlServer : DbContext
{
    public SqlServer(DbContextOptions options) : base(options) { }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Insurance> Insurances { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
