using Microsoft.EntityFrameworkCore;
using WodScore.Models;

namespace WodScore.Data.DbAccess
{
    public class WodScoreDbContext : DbContext
    {
        public WodScoreDbContext(DbContextOptions<WodScoreDbContext> options) : base(options)
        {            
        }

        public DbSet<Score> Scores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Score>().ToTable("Score");
        }
    }
}
