using Microsoft.EntityFrameworkCore;
using Project_HMI_.Infrastructure;
using Project_HMI_.Services.Shared;

namespace Project_HMI_.Services
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext()
        {
        }

        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        {
            DataGenerator.InitializeUsers(this);
        }

        public DbSet<User> Users { get; set; }
    }
}
