using Microsoft.EntityFrameworkCore;

namespace SynergicFailureAftermath.Database
{
    public class SubsetsContext : DbContext
    {
        public DbSet<Subset> Subsets { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=Subsets.db");
    }
}
