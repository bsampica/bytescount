using bytescount.Models;
using Microsoft.EntityFrameworkCore;

namespace bytescount.Context
{
    public class BytesDbContext : DbContext
    {
        public BytesDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Thing> Things { get; set; }
    }
}