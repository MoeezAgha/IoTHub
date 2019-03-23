using InternetOfKings.Model;
using Microsoft.EntityFrameworkCore;

namespace InternetOfKings.EntityFramework
{
    public class InternetOfKingsContext : DbContext
    {
        public DbSet<LogInformation> LogInformations { get; set; }

        public InternetOfKingsContext(DbContextOptions<InternetOfKingsContext> options) : base(options) { }
    }
}
