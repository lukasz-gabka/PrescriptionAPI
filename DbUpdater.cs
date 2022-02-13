using Microsoft.EntityFrameworkCore;
using PrescriptionAPI.Entities;

namespace PrescriptionAPI;

public class DbUpdater
{
    private ApiDbContext _dbContext;

    public DbUpdater(ApiDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Update()
    {
        if (_dbContext.Database.CanConnect())
        {
            var pendingMigrations = _dbContext.Database.GetPendingMigrations();

            if (pendingMigrations != null && pendingMigrations.Any())
            {
                _dbContext.Database.Migrate();
            }
        }
    }
}
