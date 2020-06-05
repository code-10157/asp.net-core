using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Test3.Models
{
    public class ArticleContext : DbContext
    {
        public ArticleContext (DbContextOptions<ArticleContext> options)
            : base(options)
        {
        }

        public DbSet<Test3.Models.Article> Article { get; set; }
    }
}
