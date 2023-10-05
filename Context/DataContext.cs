using Crito.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace Crito.Context
{
    public class DataContext : DbContext
    {
        public DataContext() { }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<ContactUsEntity> ContactUsMessages { get; set; }
        public DbSet<SubscriberEntity> Subscribers { get; set; }
    }
}
