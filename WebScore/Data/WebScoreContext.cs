using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebScore.Models;

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
