using Microsoft.EntityFrameworkCore;

namespace PrescriptionAPI.Entities
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {

        }
    }
}
