using Microsoft.EntityFrameworkCore;
using CustomerEngagementPlatform.Models;

namespace CustomerEngagementPlatform.Data
{
    // Database Context Class
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext
        (
            DbContextOptions<ApplicationDbContext> options
        ) : base(options)
        {
        }

        // Customer Table
        public DbSet<Customer> Customers { get; set; }

        // Ticket Table
        public DbSet<Ticket> Tickets { get; set; }
    }
}