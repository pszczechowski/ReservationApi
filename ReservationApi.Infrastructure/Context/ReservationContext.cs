using Microsoft.EntityFrameworkCore;
using ReservationApi.Infrastructure.Model;

namespace ReservationApi.Infrastructure.Context
{
    public class ReservationContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Room> Room { get; set; }
        
        public ReservationContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=dbo.ReservationApi.db");
        }
        
    }
}