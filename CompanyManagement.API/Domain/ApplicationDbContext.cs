using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.API.Domain
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Modules.Management.Entities.Task> Tasks { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }
    }
}
