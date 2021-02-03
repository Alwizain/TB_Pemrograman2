using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class MvcSpicyoContext : DbContext
    {
        public MvcSpicyoContext(DbContextOptions<MvcSpicyoContext> options)
            : base(options)
        {
        }

        public DbSet<Spicyo> Spicyo { get; set; }
    }
}