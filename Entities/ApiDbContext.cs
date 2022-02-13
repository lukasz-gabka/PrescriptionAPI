using Microsoft.EntityFrameworkCore;

namespace PrescriptionAPI.Entities;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
    }

    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Medicine> Medicines { get; set; }
}
