using CatMashApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatMashApi.Helpers
{
    public class CatScoreContext : DbContext
    {
            public CatScoreContext(DbContextOptions<CatScoreContext> options) : base(options) { }

            public virtual DbSet<CatScore> CatScores { get; set; }
    }
}
