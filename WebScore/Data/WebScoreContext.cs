using Microsoft.EntityFrameworkCore;

namespace WebScore.Data
{
    public class WebScoreContext : DbContext
    {
        public WebScoreContext (DbContextOptions<WebScoreContext> options)
            : base(options)
        {
        }

        public DbSet<WebScore.Models.Department> Department { get; set; }
    }
}
